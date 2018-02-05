using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Configuration.Jbxx
{
    internal class JbxxCreatedMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_jbxx_create"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> ReceiveEndPointBinding
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<JbxxCreatedMessageConsumer>(); });
                    };
            }
        }
    }
}