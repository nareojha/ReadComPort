using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ReadPort
{
    public partial class ReadCOMPort : ServiceBase
    {
        public ReadCOMPort()
        {
            InitializeComponent();
            EventLog.Log = "ReadCOMPort";
        }

        protected override void OnStart(string[] args)
        {

            EventLog.WriteEntry("Service started Successfully");

        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("Service was stopped Successfully");
        }

        protected override void OnShutdown()
        {
            EventLog.WriteEntry("Service was Shutdown successfully");
        }

       private string ReadSerialPort(string portName)
        {
            return "yes";
        }
    }
}
