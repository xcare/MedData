using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonServiceLocator;
using Unity;
using Unity.ServiceLocation;
using XCare.DMS.Uploading.Events;

namespace XCare.DMS.Uploading.Host
{
    static class Program
    {
        private static readonly IUnityContainer AmbientContainer = new UnityContainer();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IocConfig.Configure(AmbientContainer);
            Application.Run(new FrmMain());
        }
    }
}
