using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Jbxx
{
    public class CreateJbxxMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_jbxx_create"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> SetReceiveEndPointHandle
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<CreateJbxxMessageConsumer>(); });
                    };
            }
        }
    }
}