using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Jcbg
{
    internal class UpdateJcbgMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_jcbg_udt"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> SetReceiveEndPointHandle
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<UpdateJcbgMessageConsumer>(); });
                    };
            }
        }
    }
}