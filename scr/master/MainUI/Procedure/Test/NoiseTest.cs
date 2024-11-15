namespace MainUI.Procedure.Test
{
    /// <summary>
    /// 气密性试验
    /// </summary>
    public class NoiseTest : BaseTest
    {
        ParaConfig paraconfig = new ParaConfig();

        //uint T1;
        public override bool Execute()
        {
            paraconfig = new ParaConfig();
            paraconfig.SetSectionName(Common.mTestViewModel.ModelName);
            paraconfig.Load();
            try
            {
                TestStatus(true);
                TxtTips("气密性试验开始");


                TestStatus(false);
                TxtTips("气密性试验结束");
                return true;
            }
            catch (Exception ex)
            {
                TxtTips("气密性试验失败，原因：" + ex.Message);
                return false;
            }
        }
    }
}
