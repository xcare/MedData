using System;
using System.Configuration;
using MassTransit;
using MassTransit.RabbitMqTransport;

namespace XCare.DMS.Message.Configuration
{
    public abstract class BusConfig
    {
        protected BusConfig()
        {
            Initialize();
        }

        /// <summary>
        ///     RabbitMQ Address
        /// </summary>
        public virtual string Address { get; protected set; }

        public abstract string QueueName { get; }

        /// <summary>
        ///     RabbitMQ UserName
        /// </summary>
        public virtual string UserName { get; protected set; }

        /// <summary>
        ///     RabbitMQ Password
        /// </summary>
        public virtual string Password { get; protected set; }

        /// <summary>
        ///     Message Scheduler Uri
        /// </summary>
        public virtual string SchedulerUri { get; protected set; }

        public abstract Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> ReceiveEndPointBinding { get; }

        public virtual IBusControl CreateBus()
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                var host = cfg.Host(new Uri(Address), settings =>
                {
                    settings.Username(UserName);
                    settings.Password(Password);
                });
                cfg.UseMessageScheduler(new Uri(SchedulerUri));
                ReceiveEndPointBinding.Invoke(cfg, host);
            });
            bus.Start();
            return bus;
        }

        protected void Initialize()
        {
            Address = ConfigurationManager.AppSettings["RabbitMQAddress"];
            UserName = ConfigurationManager.AppSettings["RabbitMQUserName"];
            Password = ConfigurationManager.AppSettings["RabbitMQPassword"];
            SchedulerUri = ConfigurationManager.AppSettings["MessageSchedulerUri"];
        }
    }
}