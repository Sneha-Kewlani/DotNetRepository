using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MyFirstService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("MyFirstServiceSource"))
                System.Diagnostics.EventLog.CreateEventSource("MyFirstServiceSource", "MyFirstServiceLog");

            eventLog1.Source = "MyFirstServiceSource";
            eventLog1.Log = "MyFirstServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("My First Service started successfully");
            Timer timer = new Timer();
            timer.Interval = 60000; // 60 seconds
            timer.Elapsed += new ElapsedEventHandler(this.onTimer);
            timer.Start();



        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("My First Service stopped");
        }

        public void onTimer(object sender, ElapsedEventArgs args)
        {
            eventLog1.WriteEntry("60 seconds done!!!", EventLogEntryType.Warning);
        }
    }
}
