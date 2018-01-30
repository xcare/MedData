using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Jybg
{
    public class CreateJybgMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_jybg_create"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> SetReceiveEndPointHandle
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<CreateJybgMessageConsumer>(); });
                    };
            }
        }
    }
}