namespace ServoTired.Model
{
    internal class ServoTiredModel
    {
        /// <summary>
        /// 表ID，自增列
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 档位停留时间
        /// </summary>
        public int ResidenceTime { get; set; }
        /// <summary>
        /// 电机运转速度
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// 开始位置ID
        /// </summary>
        public int StartPositionID { get; set; }

        /// <summary>
        /// 结束位置ID
        /// </summary>
        public int StopPositionID { get; set; }
    }
}
