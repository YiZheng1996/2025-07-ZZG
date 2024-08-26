using FreeSql.DataAnnotations;

namespace ServoTired.Model
{
    [Table(Name = "PointTable")]
    internal class PointModel
    {
        /// <summary>
        /// 表ID，自增列
        /// </summary>
        [Column(IsIdentity = true, IsPrimary = true)]
        public int ID { get; set; }

        /// <summary>
        /// 档位名称
        /// </summary>
        public string GearPposition { get; set; } = string.Empty;

        /// <summary>
        /// 点位信息，OPC中Servo组P000
        /// </summary>
        public int Point { get; set; }

        /// <summary>
        /// 指令信息，1-9代表运转位-常用制动区（3-9）-紧急制动（开始位置）
        /// </summary>
        public int Instruct { get; set; }

        /// <summary>
        /// 大小端类型 0:大闸，1:小闸
        /// </summary>
        public int GearType { get; set; }

    }
}
