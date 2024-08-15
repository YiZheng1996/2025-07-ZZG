using NLog;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System;
using System.Linq;
using NLog.Targets;

namespace MainUI
{
    /// <summary>
    /// 日志类
    /// </summary>
    public class NlogHelper
    {
        #region 初始化
        /// <summary>
        /// 日事件间类
        /// </summary>
        private readonly LogEventInfo _logEventInfo = new();

        /// <summary>
        /// 应用名称
        /// </summary>
        public static string AppName = string.Empty;

        /// <summary>
        /// 提供日志接口和实用程序功能
        /// </summary>
        public readonly Logger _logger = null;
        /// <summary>
        /// 自定义日志对象供外部使用
        /// </summary>
        public static NlogHelper Default { get; private set; }

        private NlogHelper(Logger logger)
        {
            //var dbTarget = logger.Factory.Configuration.AllTargets.Where(f => f.Name == "logDB_wrapped").FirstOrDefault() as DatabaseTarget;
            logger = LogManager.GetCurrentClassLogger();
            _logger = logger;
        }

        public NlogHelper(string name) : this(LogManager.GetLogger(name)) { }

        static NlogHelper()
        {
            //获取具有当前类名称的日志程序。
            Default = new NlogHelper("Logger");
        }
        #endregion

        //Trace - 最详细的日志信息，通常用于诊断问题。
        //Debug - 用于提供调试应用程序时的信息。
        //Info - 用于提供提示用户注意的一般信息。
        //Warn - 用于表明有潜在问题的情况。
        //Error - 用于表明错误情况发生了。
        //Fatal - 用于表明发生了严重错误，应用程序可能会停止运行。
        #region 等级分类
        public void Debug(string msg, params object[] args)
        {
            var message = string.Empty;
            if (args != null)
            {
                message = string.Format(msg, args);
            }
            InsLog(LogLevel.Debug, message);
        }

        public void Info(string msg, params object[] args)
        {
            var message = string.Empty;
            if (args != null)
            {
                message = string.Format(msg, args);
            }
            InsLog(LogLevel.Info, message);
        }

        /// <summary>
        ///警告
        /// </summary>
        /// <param name="msg">警告信息</param>
        /// <param name="args">动态参数</param>
        public void Warn(string msg, params object[] args)
        {
            var message = string.Empty;
            if (args != null)
            {
                message = string.Format(msg, args);
            }
            InsLog(LogLevel.Warn, message);
        }

        /// <summary>
        /// 使用指定的参数在跟踪级别写入诊断消息
        /// </summary>
        /// <param name="msg">跟踪信息</param>
        /// <param name="args">动态参数</param>
        public void Trace(string msg, params object[] args)
        {
            var message = string.Empty;
            if (args != null)
            {
                message = string.Format(msg, args);
            }
            InsLog(LogLevel.Trace, message);
        }

        public void Fatal(string msg, params object[] args)
        {
            var message = string.Empty;
            if (args != null)
            {
                message = string.Format(msg, args);
            }
            InsLog(LogLevel.Fatal, message);
        }
        #endregion

        #region Error
        /// <summary>
        /// 使用指定的参数在错误级别写入诊断消息。
        /// </summary>
        /// <param name="msg">错误信息</param>
        /// <param name="args">动态参数</param>
        public void Error(string msg, params object[] args)
        {
            var message = string.Empty;
            if (args != null)
            {
                message = string.Format(msg, args);
            }
            InsLog(LogLevel.Error, message);
        }
        /// <summary>
        /// 使用指定的参数在错误级别写入诊断消息。
        /// </summary>
        /// <param name="msg">错误信息</param>
        /// <param name="args">异常信息</param>
        public void Error(string msg, Exception err)
        {
            InsLog(LogLevel.Error, msg, err);
        }
        #endregion

        #region 日志写入
        /// <summary>
        /// 写入日志信息
        /// </summary>
        private void InsLog(LogLevel level, string msg, Exception ex = null)
        {
            var stackTrace = string.Empty;
            if (ex != null)
            {
                stackTrace = string.Format("StackTrace:{0},Message:", ex.StackTrace);
                var exception = ex;
                do
                {
                    stackTrace += exception.Message;
                    exception = exception.InnerException;

                } while (exception != null);
            }

            _logEventInfo.Properties["UserName"] = RWUser.User.Username;
            _logEventInfo.Level = level;
            _logEventInfo.Message = stackTrace + msg;
            _logEventInfo.Exception = ex;
            _logger.Log(_logEventInfo);
        }
        #endregion 
    }
}