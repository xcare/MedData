using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Twd
{
    public class CreateTwdMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_twd_create"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> SetReceiveEndPointHandle
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<CreateTwdMessageConsumer>(); });
                    };
            }
        }
    }
}