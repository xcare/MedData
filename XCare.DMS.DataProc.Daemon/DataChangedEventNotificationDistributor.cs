using System;

namespace XCare.DMS.DataProc.Daemon
{
    internal class DataChangedEventNotificationDistributor
    {
        public static void Distribute(DataChangedEventNotification notification)
        {
            Console.WriteLine("notified");
        }
    }
}