using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Ypzd
{
    internal class UpdateYpzdMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_ypzd_udt"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> SetReceiveEndPointHandle
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<UpdateYpzdMessageConsumer>(); });
                    };
            }
        }
    }
}