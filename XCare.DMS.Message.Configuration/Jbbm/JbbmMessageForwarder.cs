using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassTransit;
using XCare.DMS.Message.Configuration.Gyzd;
using XCare.DMS.Message.Gyzd;
using XCare.DMS.Message.Jbbm;

namespace XCare.DMS.Message.Configuration.Jbbm
{
   public class JbbmMessageForwarder
   {
       private static readonly IBusControl CreateBus = new JbbmCreatedMessageBusConfig().CreateBus();
       private static readonly IBusControl UpdateBus = new JbbmUpdatedMessageBusConfig().CreateBus();

       public static void Forward(JbbmCreatedMessage message)
       {
           CreateBus.Publish(message);
       }

       public static void Forward(JbbmUpdatedMessage message)
       {
           UpdateBus.Publish(message);
       }
    }
}
