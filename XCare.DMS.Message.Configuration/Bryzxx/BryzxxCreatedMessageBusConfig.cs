using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Configuration.Bryzxx
{
    internal class BryzxxCreatedMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_bryzxx_create"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> ReceiveEndPointBinding
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<BryzxxCreatedMessageConsumer>(); });
                    };
            }
        }
    }
}