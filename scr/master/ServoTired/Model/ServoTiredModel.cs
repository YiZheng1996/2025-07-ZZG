using FreeSql.DataAnnotations;
using RW;

namespace ServoTired.Model
{
    [Table(Name = "ServoTiredTable")]
    internal class ServoTiredModel
    {
        /// <summary>
        /// 表ID，自增列
        /// </summary>
        [Column(IsIdentity = true, IsPrimary = true)]
        public int ID { get; set; }

        /// <summary>
        /// 停留时间
        /// </summary>
        public int ResidenceTime { get; set; }

        /// <summary>
        /// 步骤号
        /// </summary>
        public int StepNumber { get; set; }

        /// <summary>
        /// 电机运转速度
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// 位置ID，原：开始位置ID
        /// </summary>
        public int StartPositionID { get; set; }

        /// <summary>
        /// 结束位置ID（废弃字段）
        /// </summary>
        [Obsolete("因修改下位机逻辑，废弃字段，直接用StartPositionID 绑定位置")]
        public int StopPositionID { get; set; }

        /// <summary>
        /// 大小端类型 0:大闸，1:小闸
        /// </summary>
        public int SGearType { get; set; }
    }

    public class ServoTiredModelDto
    {
        public int ID { get; set; }
        public int ResidenceTime { get; set; }
        public int StepNumber { get; set; }
        public int Speed { get; set; }
        public int StartPositionID { get; set; }
        public string StartPosition { get; set; } = string.Empty;
        //public int StopPositionID { get; set; }
        //public string StopPosition { get; set; } = string.Empty;

        private int _GearType;
        public int GearType { get => _GearType; set { _GearType = value; UpdateValueB(); } }

        public string GearTypeText { get; set; } = string.Empty;

        private void UpdateValueB() => GearTypeText = _GearType == 0 ? GearTypeText = "大闸" : GearTypeText = "小闸";
    }

}
