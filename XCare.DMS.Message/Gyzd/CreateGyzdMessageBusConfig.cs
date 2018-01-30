using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Gyzd
{
    public class CreateGyzdMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_gyzd_create"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> SetReceiveEndPointHandle
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<CreateGyzdMessageConsumer>(); });
                    };
            }
        }
    }
}