using MainUI.BLL;
using MainUI.Model;
using RW.Driver;
using RW.EventLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace MainUI.MVB
{
    /// <summary>
    /// 主要为构建MVB的驱动使用
    /// </summary>
    public class MVBDriver : IDriver
    {
        public MVBDriver()
        {
            this.Timeout = 100;
            this.Interval = 100;

        }

        [DefaultValue(1000)]
        public int Timeout { get; set; }

        [DefaultValue(1000)]
        public int Interval { get; set; }

        private Dictionary<int, byte[]> datas = new();
        PortsBLL bllPorts = new();
        List<Ports> ps = null;
        public static bool IsInit = false;
        public void Connect()
        {
            if (IsInit)
                return;
            List<Ports> ports = bllPorts.GetPortsByType(null).ToList();
            Ports = ports;

            ps = Ports.Where(x => x.IsRead).ToList();
            for (int i = 0; i < MvbDllCall.PD_snk_port_address.Length; i++)
            {
                MvbDllCall.PD_snk_port_address[i] = 0;
                MvbDllCall.PD_snk_port_size[i] = 0;
                MvbDllCall.PD_src_port_address[i] = 0;
                MvbDllCall.PD_src_port_size[i] = 0;
            }

            int srcIndex = 0;
            int snkIndex = 0;
            for (int i = 0; i < Ports.Count; i++)
            {
                Ports p = Ports[i];
                if (p.IsRead)
                {
                    MvbDllCall.PD_snk_port_address[snkIndex] = p.PortNum;
                    MvbDllCall.PD_snk_port_size[snkIndex] = p.DataSize;
                    snkIndex++;
                }
                else
                {
                    MvbDllCall.PD_src_port_address[srcIndex] = p.PortNum;
                    MvbDllCall.PD_src_port_size[srcIndex] = p.DataSize;
                    srcIndex++;
                }
            }
            int status = MvbDllCall.startMvb();
            IsInit = true;
            EventLogHelper.Log(EventLogType.Normal, "startMvb and status:[" + status + "]");

            ThreadPool.QueueUserWorkItem(delegate
            {
                Start();
            });
            Connected?.Invoke(this, EventArgs.Empty);
        }

        void Start()
        {
            while (true)
            {
                byte[,] readed = null;

                MvbDllCall.GetCollection();
                readed = MvbDllCall.readbyte;
                for (int i = 0; i < readed.GetLength(0); i++)
                {
                    if (ps.Count <= i) break;
                    int len = readed.GetLength(1);
                    byte[] b = new byte[len];
                    for (int j = 0; j < len; j++)
                    {
                        b[j] = readed[i, j];
                    }
                    OnPortValueChanged(ps[i].PortNum, b);
                }
                this.readed = readed;
                Thread.Sleep(Interval);
            }
        }

        byte[,] readed = null;

        public void Close()
        {
            MvbDllCall.StopMvb();
            EventLogHelper.Log(EventLogType.Normal, "called stop mvb.");
        }

        public event EventHandler Connected;

        public event ValueChangeHandler ValueChanged;

        public event PortValueHandler PortValueChanged;
        public event ErrorHandler Errored;

        protected virtual void OnPortValueChanged(int port, byte[] data)
        {
            datas[port] = data;
            PortValueChanged?.Invoke(port, data);
        }

        bool BytesEquals(byte[] b1, byte[] b2)
        {
            if (b1.Length != b2.Length) return false;
            for (int i = 0; i < b1.Length; i++)
            {
                if (b1[i] != b2[i]) return false;
            }
            return true;
        }

        public List<Ports> Ports { get; set; }

        #region IDriver 成员

        public object this[string key]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public object Read(string key)
        {
            throw new NotImplementedException();
        }

        public void Write(string key, object value)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IDisposable 成员

        public void Dispose()
        {
            this.Close();
        }

        #endregion

        #region IDriver 成员


        public void LoadConfig(IDriverConfig config)
        {
            throw new NotImplementedException();
        }

        #endregion

        public bool IsConnected
        {
            get { throw new NotImplementedException(); }
        }
    }

    public delegate void PortValueHandler(int port, byte[] data);
}
