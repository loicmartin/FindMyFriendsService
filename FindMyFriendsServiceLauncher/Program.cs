using FindMyFriendsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FindMyFriendsServiceLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://192.168.1.90:6525/service");

            using (ServiceHost host = new ServiceHost(typeof(FindMyFriendsService.FindMyFriendsWebService), baseAddress))
            {
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                host.Open();

                Console.WriteLine("The service is ready at: {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service");
                Console.ReadKey();
                host.Close();
            }
        }
    }
}
