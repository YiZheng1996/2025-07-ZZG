namespace MainUI.Config
{
    public class SystemConfig : RW.Configuration.SystemConfig
    {
        protected override void PreInit()
        {
            this.Land = false;
            this.Interval = 100;
            base.PreInit();
        }

        /// <summary>
        /// 是否是地面设备，默认为false：车载设备，true：地面设备
        /// </summary>
        public bool Land { get; set; }

        /// <summary>
        /// 地面设备扫描的间隔 默认100ms
        /// </summary>
        public int Interval { get; set; }

        /// <summary>
        /// 是否自动保存数据配置
        /// </summary>
        public bool IsAutoSaveData { get; set; }

        /// <summary>
        /// 保存数据配置间隔
        /// </summary>
        public int DataSaveInterval { get; set; }

        /// <summary>
        /// 通讯数据读间隔
        /// </summary>
        public int MvbDataReadInterval { get; set; }

        /// <summary>
        /// 传感器量程
        /// </summary>
        public double SensorRange { get; set; }

    }
}
