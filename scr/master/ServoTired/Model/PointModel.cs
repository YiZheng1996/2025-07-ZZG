namespace ServoTired.Model
{
    internal class PointModel
    {
        /// <summary>
        /// 表ID，自增列
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 档位名称
        /// </summary>
        public string GearPposition { get; set; } = string.Empty;

        /// <summary>
        /// 点位信息，对应下位机参数值
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// 大小端类型 0:大闸，1:小闸
        /// </summary>
        public int GearType { get; set; }
 
    }
}
