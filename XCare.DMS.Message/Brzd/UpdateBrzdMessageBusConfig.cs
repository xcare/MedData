using System;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Brzd
{
    public class UpdateBrzdMessageBusConfig : BusConfig
    {
        public override string QueueName
        {
            get { return "xcare_dms_brzd_udt"; }
        }

        public override Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> SetReceiveEndPointHandle
        {
            get
            {
                return
                    (cfg, host) =>
                    {
                        cfg.ReceiveEndpoint(host, QueueName, e => { e.Consumer<UpdateBrzdMessageConsumer>(); });
                    };
            }
        }
    }
}