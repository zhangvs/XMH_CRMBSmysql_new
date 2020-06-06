using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using XMH.crmService;

namespace crmService
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
               // new crmNodeFeatService(),
               new imsNodeFeatService()
            };
            ServiceBase.Run(ServicesToRun);

            //test tt = new test();
            ////tt.DoAction();
            //tt.DoActionTest();
        }
    }
}
