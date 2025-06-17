using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Procedure.Curve
{
    /// <summary>
    /// Type的代理类，类似于装饰者模式，只不过实现原理从继承变为组合
    /// </summary>
    class FRType
    {
        #region 属性
        public Type Type { get; set; }
        public FRPropertyCollection FRPropertyCollection { get; set; }
        public CreaterFunction Creater { get; set; }
        #endregion
        #region 构造函数
        public FRType(Type type)
        {
            this.Type = type;
            this.FRPropertyCollection = new FRPropertyCollection(Type);
            if (!this.Type.IsGenericTypeDefinition)
                this.Creater = CreateCreaterFunction(this.Type);
        }
        #endregion

        #region il
        //***************************************************************************************************************//
        // Evaluation Stack 计算栈，存放值类型和引用地址，unsafe代码优化的目标，节省装箱拆箱操作，遵从FILO原则           //
        // Call Stack中的RecordFrame 局部变量表，方便调用局部变量，不遵从FILO原则                                        //
        // Managed Heep 托管堆，存放引用对象，由GC管理，一般IL不涉及其操作                                               //
        //***************************************************************************************************************//
        public static CreaterFunction CreateCreaterFunction(Type type)
        {
            if (type.IsValueType)
            {
                return () => Activator.CreateInstance(type);
            }
            else
            {
                //预定义要用到的方法
                var type_constructor = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance).First(e => e.GetParameters().Length == 0);
                //定义【参数列表】，注：动态方法是静态的
                var dm = new DynamicMethod("", typeof(object), [], type, true);
                var il = dm.GetILGenerator();
                //处理【计算栈】,可以模拟一个静态函数,然后使用IL DASM的汇编结果
                il.Emit(OpCodes.Newobj, type_constructor);
                il.Emit(OpCodes.Ret);
                return (CreaterFunction)dm.CreateDelegate(typeof(CreaterFunction));
            }
        }
        #endregion
    }

    public class FRProperty
    {
        #region 属性
        public string Name { get; set; }//用于检索FRProperty

        public Type PropertyType { get; set; }//属性的类型
        public IEnumerable<string> Attributes { get; set; }//属性上的所有标签
        public bool IsArray { get; set; }
        public bool IsList { get; set; }
        public Type elementType { get; set; }//若是Array,IList或可空类型,则为其元素的类型，反之为null
        public bool IsNullable { get; set; }


        public delegate object GetterFunction(object obj);
        public GetterFunction Getter { get; set; }//Getter的方法
        public delegate void SetterFunction(object obj, object value);
        public SetterFunction Setter { get; set; }//Setter的方法
        #endregion
        #region 构造函数
        public FRProperty(PropertyInfo prop)
        {
            Name = prop.Name;
            PropertyType = prop.PropertyType;
            IsArray = PropertyType.IsArray;
            IsList = string.Compare(PropertyType.Name, "List`1") == 0;
            Attributes = from e in prop.GetCustomAttributes(true) select e.GetType().Name;
            IsNullable = PropertyType.IsGenericType && PropertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>));
            elementType = IsArray ? PropertyType.GetElementType() : (IsList || IsNullable ? PropertyType.GetGenericArguments()[0] : null);
            Getter = CreateGetterFunction(prop);
            Setter = CreateSetterFunction(prop);
        }
        #endregion
        #region il
        //***************************************************************************************************************//
        // Evaluation Stack 计算栈，存放值类型和引用地址，unsafe代码优化的目标，节省装箱拆箱操作，遵从FILO原则           //
        // Call Stack中的RecordFrame 局部变量表，方便调用局部变量，不遵从FILO原则                                        //
        // Managed Heep 托管堆，存放引用对象，由GC管理，一般IL不涉及其操作                                               //
        //***************************************************************************************************************//
        public static GetterFunction CreateGetterFunction(PropertyInfo prop)
        {
            Type ReflectedType = prop.ReflectedType;
            Type DeclaringType = prop.DeclaringType;
            Type PropertyType = prop.PropertyType;
            //预定义要用到的方法
            var met = ReflectedType.GetMethod("get_" + prop.Name);
            if (met == null)
                return null;
            //定义【参数列表】，注：动态方法是静态的
            var dm = new DynamicMethod("", typeof(object), new Type[] { typeof(object) }, ReflectedType, true);
            var il = dm.GetILGenerator();
            //定义【局部变量列表】
            //il.DeclareLocal(type);
            //处理【计算栈】,可以模拟一个静态函数,然后使用IL DASM的汇编结果
            if (met.IsStatic)
                il.Emit(OpCodes.Call, met);
            else
            {
                il.Emit(OpCodes.Ldarg_0);
                if (DeclaringType.IsValueType)
                {
                    il.Emit(OpCodes.Unbox_Any, DeclaringType);
                    if (Nullable.GetUnderlyingType(DeclaringType) == null)
                    {
                        var t = il.DeclareLocal(DeclaringType);
                        il.Emit(OpCodes.Stloc, t);
                        il.Emit(OpCodes.Ldloca_S, t);
                    }
                }
                else
                    il.Emit(OpCodes.Castclass, DeclaringType);
                if (DeclaringType.IsValueType)
                    il.Emit(OpCodes.Call, met);
                else
                    il.Emit(OpCodes.Callvirt, met);
            }
            if (PropertyType.IsValueType)
                il.Emit(OpCodes.Box, PropertyType);
            il.Emit(OpCodes.Ret);
            return (GetterFunction)dm.CreateDelegate(typeof(GetterFunction));
        }

        public static SetterFunction CreateSetterFunction(PropertyInfo prop)
        {
            Type ReflectedType = prop.ReflectedType;
            Type DeclaringType = prop.DeclaringType;
            Type PropertyType = prop.PropertyType;
            //预定义要用到的方法
            var set = ReflectedType.GetMethod("set_" + prop.Name);
            if (set == null)
                return null;
            //定义【参数列表】，注：动态方法是静态的
            var dm = new DynamicMethod("", null, new Type[] { typeof(Object), typeof(Object) }, ReflectedType, true);
            var il = dm.GetILGenerator();
            //定义【局部变量列表】
            //il.DeclareLocal(type);
            //处理【计算栈】,可以模拟一个静态函数,然后使用IL DASM的汇编结果
            if (set.IsStatic)
            {
                il.Emit(OpCodes.Ldarg_1);
                if (PropertyType.IsValueType)
                    il.Emit(OpCodes.Unbox_Any, PropertyType);
                else
                    il.Emit(OpCodes.Castclass, PropertyType);
                il.Emit(OpCodes.Call, set);
            }
            else
            {
                il.Emit(OpCodes.Ldarg_0);
                il.Emit(OpCodes.Castclass, DeclaringType);
                il.Emit(OpCodes.Ldarg_1);
                if (PropertyType.IsValueType)
                    il.Emit(OpCodes.Unbox_Any, PropertyType);
                else
                    il.Emit(OpCodes.Castclass, PropertyType);
                il.Emit(OpCodes.Callvirt, set);
            }
            il.Emit(OpCodes.Ret);
            return (SetterFunction)dm.CreateDelegate(typeof(SetterFunction));
        }
        #endregion
    }

    public delegate object CreaterFunction();
    class FRTypeCollection : IEnumerable<FRType>
    {
        #region 单例模式
        private volatile static FRTypeCollection _instance = null;
        private static readonly object lockHelper = new object();
        public static FRTypeCollection Instance()
        {
            if (_instance == null)
            {
                lock (lockHelper)
                {
                    if (_instance == null)
                        _instance = new FRTypeCollection();
                }
            }
            return _instance;
        }
        #endregion
        #region 属性
        private readonly Dictionary<Type, FRType> _Items;
        #endregion
        #region 构造函数
        private FRTypeCollection()
        {
            _Items = new Dictionary<Type, FRType>();
        }
        #endregion
        #region Collection
        public FRType this[Type name]
        {
            get
            {
                FRType value;
                if (!_Items.TryGetValue(name, out value))
                {
                    value = new FRType(name);
                    Add(value);
                }
                return value;
            }
        }
        internal void Add(FRType value)
        {
            var name = value.Type;
            FRType p;
            if (!_Items.TryGetValue(name, out p))
            {
                lock (lockHelper)
                {
                    if (!_Items.TryGetValue(name, out p))
                    {
                        _Items.Add(name, value);
                    }
                }
            }
        }
        public bool ContainsKey(Type name)
        {
            return _Items.ContainsKey(name);
        }
        public ICollection<Type> Names
        {
            get { return _Items.Keys; }
        }
        public int Count
        {
            get { return _Items.Count; }
        }
        #endregion
        #region 迭代器
        public IEnumerator<FRType> GetEnumerator()
        {
            foreach (var item in _Items)
            {
                yield return item.Value;
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _Items.Values.GetEnumerator();
        }
        #endregion
    }

    public class FRPropertyCollection : IEnumerable<FRProperty>
    {
        #region 属性
        public Dictionary<string, FRProperty> _Items;
        #endregion
        #region 构造函数
        public FRPropertyCollection(Type type)
        {
            _Items = new Dictionary<string, FRProperty>();
            foreach (var p in type.GetProperties())//指搜索包含公共的实例成员  BindingFlags.Public | BindingFlags.Instance
            {
                if (p.GetIndexParameters().Length == 0) //排除索引器，一般的属性是不含参数的
                {
                    if (!ContainsKey(p.Name))//防止重复添加
                    {
                        var a = new FRProperty(p);
                        Add(a);
                    }
                }
            }
        }
        #endregion
        #region Collection
        public FRProperty this[string name, bool exactitude = true]
        {
            get
            {
                FRProperty value = null;
                if (exactitude)
                {
                    _Items.TryGetValue(name, out value);
                }
                else
                {
                    foreach (FRProperty p in this)
                    {
                        if (string.Compare(p.Name, name, true) == 0)
                        {
                            value = p;
                            break;
                        }
                    }
                }
                return value;
            }
        }
        internal void Add(FRProperty value)
        {
            var name = value.Name;
            FRProperty p;
            if (!_Items.TryGetValue(name, out p))
            {
                _Items.Add(name, value);
            }
        }
        public bool ContainsKey(string name)
        {
            return _Items.ContainsKey(name);
        }
        public ICollection<string> Names
        {
            get { return _Items.Keys; }
        }
        public int Count
        {
            get { return _Items.Count; }
        }
        #endregion
        #region 迭代器
        public IEnumerator<FRProperty> GetEnumerator()
        {
            foreach (var item in _Items)
            {
                yield return item.Value;
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _Items.Values.GetEnumerator();
        }
        #endregion
    }
   
}
