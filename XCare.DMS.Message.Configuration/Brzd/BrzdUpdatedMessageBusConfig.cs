using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Configuration.Brzd
{
    internal class BrzdUpdatedMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_brzd_udt"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> ReceiveEndPointBinding
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<BrzdUpdatedMessageConsumer>(); });
                    };
            }
        }
    }
}