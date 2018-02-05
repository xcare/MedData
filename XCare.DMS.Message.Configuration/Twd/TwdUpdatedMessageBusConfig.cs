using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Configuration.Twd
{
    internal class TwdUpdatedMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_twd_udt"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> ReceiveEndPointBinding
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<TwdUpdatedMessageConsumer>(); });
                    };
            }
        }
    }
}