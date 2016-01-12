using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ServiceModel;

namespace MockTransitClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FaultServices.FaultReportContractClient proxy = new FaultServices.FaultReportContractClient();
            proxy.ClientCredentials.UserName.UserName = "p-xlz-01";
            proxy.ClientCredentials.UserName.Password = "123";
            try
            {
                string InstrumentID = "0012015010401";
                string FaultCode = "E010101";
                proxy.TellNetStatus(InstrumentID, true);
                Console.WriteLine("update instrument status");
                var eventID = proxy.AutoFaultReport(InstrumentID, FaultCode, "", DateTime.Now);
                byte[] file = new byte[64 * 1024 - 1];
                for (int i = 0; i < file.Length; i++)
                    file[i] = 0x14;
                proxy.SendAttachedFile(InstrumentID, eventID, file);
            }
            catch (FaultException ex)
            {
                Console.WriteLine("ex.message: ", ex.Message);
            }
            Console.Read();
        }
    }
}
