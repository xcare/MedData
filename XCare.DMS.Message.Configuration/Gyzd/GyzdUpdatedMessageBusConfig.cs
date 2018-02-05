using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Configuration.Gyzd
{
    internal class GyzdUpdatedMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_gyzd_udt"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> ReceiveEndPointBinding
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<GyzdUpdatedMessageConsumer>(); });
                    };
            }
        }
    }
}