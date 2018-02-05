using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Configuration.Brxz
{
    internal class BrxzUpdatedMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_brxz_udt"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> ReceiveEndPointBinding
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<BrxzUpdatedMessageConsumer>(); });
                    };
            }
        }
    }
}