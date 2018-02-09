using Quartz.Impl;

namespace XCare.DMS.DataProc.Daemon
{
    public class DaemonService
    {
        public static void Start()
        {
            var scheduler = new StdSchedulerFactory().GetScheduler();
            scheduler.Start();
        }
    }
}