using FindMyFriendsService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FindMyFriendsLauncher
{
    public partial class Service1 : ServiceBase
    {
        ServiceHost host;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            
        }

        protected override void OnStop()
        {
            host.Close();
        }
    }
}
