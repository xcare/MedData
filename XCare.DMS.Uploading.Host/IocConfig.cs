using CommonServiceLocator;
using Unity;
using Unity.ServiceLocation;
using XCare.DMS.Uploading.Events.Brxz;
using XCare.DMS.Uploading.Events.Bryz;
using XCare.DMS.Uploading.Events.Brzd;
using XCare.DMS.Uploading.Events.Gyzd;
using XCare.DMS.Uploading.Events.Jbbm;
using XCare.DMS.Uploading.Events.Jbxx;
using XCare.DMS.Uploading.Events.Jcbg;
using XCare.DMS.Uploading.Events.Jybg;
using XCare.DMS.Uploading.Events.Twd;
using XCare.DMS.Uploading.Events.Ypyf;
using XCare.DMS.Uploading.Events.Ypzd;
using XCare.DMS.Utilities.Event;

namespace XCare.DMS.Uploading.Host
{
    internal static class IocConfig
    {
        public static void Configure(IUnityContainer container)
        {
            //Bryzxx
            container.RegisterType<IEventHandler<BryzxxCreatedEvent>, BryzxxCreatedEventHandler>(
                "BryzxxCreatedEventHandler");
            container.RegisterType<IEventHandler<BryzxxUpdatedEvent>, BryzxxUpdatedEventHandler>(
                "BryzxxUpdatedEventHandler");
            //Brzd
            container.RegisterType<IEventHandler<BrzdCreatedEvent>, BrzdCreatedEventHandler>(
                "BrzdCreatedEventHandler");
            container.RegisterType<IEventHandler<BrzdUpdatedEvent>, BrzdUpdatedEventHandler>(
                "BrzdUpdatedEventHandler");
            //Gyzd
            container.RegisterType<IEventHandler<GyzdUpdatedEvent>, GyzdUpdatedEventHandler>(
                "GyzdUpdatedEventHandler");
            //Jbxx
            container.RegisterType<IEventHandler<JbxxCreatedEvent>, JbxxCreatedEventHandler>(
                "JbxxCreatedEventHandler");
            container.RegisterType<IEventHandler<JbxxUpdatedEvent>, JbxxUpdatedEventHandler>(
                "JbxxUpdatedEventHandler");
            //Jbbm
            container.RegisterType<IEventHandler<JbbmCreatedEvent>, JbbmCreatedEventHandler>(
                "JbbmCreatedEventHandler");
            container.RegisterType<IEventHandler<JbbmUpdatedEvent>, JbbmUpdatedEventHandler>(
                "JbbmUpdatedEventHandler");
            //Jcbg
            container.RegisterType<IEventHandler<JcbgCreatedEvent>, JcbgCreatedEventHandler>(
                "JcbgCreatedEventHandler");
            container.RegisterType<IEventHandler<JcbgUpdatedEvent>, JcbgUpdatedEventHandler>(
                "JcbgUpdatedEventHandler");
            //Jybg
            container.RegisterType<IEventHandler<JybgCreatedEvent>, JybgCreatedEventHandler>(
                "JybgCreatedEventHandler");
            container.RegisterType<IEventHandler<JybgUpdatedEvent>, JybgUpdatedEventHandler>(
                "JybgUpdatedEventHandler");
            //Twd
            container.RegisterType<IEventHandler<TwdCreatedEvent>, TwdCreatedEventHandler>(
                "TwdCreatedEventHandler");
            container.RegisterType<IEventHandler<TwdUpdatedEvent>, TwdUpdatedEventHandler>(
                "TwdUpdatedEventHandler");
            //Ypyf
            container.RegisterType<IEventHandler<YpyfCreatedEvent>, YpyfCreatedEventHandler>(
                "YpyfCreatedEventHandler");
            container.RegisterType<IEventHandler<YpyfUpdatedEvent>, YpyfUpdatedEventHandler>(
                "YpyfUpdatedEventHandler");
            //Ypzd
            container.RegisterType<IEventHandler<YpzdCreatedEvent>, YpzdCreatedEventHandler>(
                "YpzdUpdatedEventHandler");
            container.RegisterType<IEventHandler<YpzdUpdatedEvent>, YpzdUpdatedEventHandler>(
                "YpzdUpdatedEventHandler");
            //Brxz
            container.RegisterType<IEventHandler<BrxzCreatedEvent>, BrxzCreatedEventHandler>(
                "BrxzCreatedEventHandler");
            container.RegisterType<IEventHandler<BrxzUpdatedEvent>, BrxzUpdatedEventHandler>(
                "BrxzUpdatedEventHandler");

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(container));
        }
    }
}