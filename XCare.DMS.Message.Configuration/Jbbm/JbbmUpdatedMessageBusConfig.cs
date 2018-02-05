using System;
using MassTransit;
using MassTransit.RabbitMqTransport;
using XCare.DMS.Message.Configuration.Jcbg;

namespace XCare.DMS.Message.Configuration.Jbbm
{
    internal class JbbmUpdatedMessageBusConfig:BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_jbbm_udt"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> ReceiveEndPointBinding
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<JbbmUpdatedMessageConsumer>(); });
                    };
            }
        }
    }
}