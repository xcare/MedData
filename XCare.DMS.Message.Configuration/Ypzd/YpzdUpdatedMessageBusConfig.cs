using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Configuration.Ypzd
{
    internal class YpzdUpdatedMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_ypzd_udt"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> ReceiveEndPointBinding
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<YpzdUpdatedMessageConsumer>(); });
                    };
            }
        }
    }
}