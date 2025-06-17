using MainUI.TRDP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Procedure.Test
{
    public class DSLTest(CancellationToken cancellationToken) : BaseTest
    {
        public override Task<bool> Execute()
        {
            TestStatus(true);
            TxtTips("试验开始");
            var TaskState = cancellationToken.IsCancellationRequested;
            Debug.WriteLine("-------在线试验开始-------");
            Delay(90, 100, cancellationToken, () => Common.DIgrp[26].ToBool());
            Debug.WriteLine("-------在线试验结束-------");
            TxtTips("试验完成");
            TestStatus(false);
            return Task.FromResult(true);
        }
    }
}
