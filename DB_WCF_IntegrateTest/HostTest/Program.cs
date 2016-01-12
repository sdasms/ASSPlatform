using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using FaultReportServer;
using System.Threading;

namespace HostTest
{
    class Program
    {
        static void Main(string[] args)
        {
                ServiceHost host = new ServiceHost(typeof(FaultReportService));
                host.Open();
                Console.WriteLine("started");
                System.Threading.Timer timer = new Timer(new TimerCallback(CheckOnlineStatus), null, 0, 5000);
                Console.WriteLine("timer started");
                Console.Read();
                host.Close();
                Console.WriteLine("closed");
                Console.Read();
        }

        private static void CheckOnlineStatus(object obj)
        {
            using (FaultDataContext fdc = new FaultDataContext())
            {
                try
                {
                    var Now = DateTime.Now;
                    foreach (var instrument in fdc.Instrument)
                    {
                        if (instrument.LastUpdateTime.HasValue)
                            if (instrument.IsOnline && (Now - instrument.LastUpdateTime.Value).TotalSeconds > 520)
                            {
                                instrument.IsOnline = false;
                                //Console.WriteLine("instrument ID {o} offline", instrument.GUID);
                            }
                    }
                    fdc.SubmitChanges();
                }
                catch (Exception)
                { }
            }
        }
    }
}
