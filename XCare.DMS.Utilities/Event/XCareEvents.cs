using System;
using System.Collections.Generic;
using CommonServiceLocator;

namespace XCare.DMS.Utilities.Event
{
    /// <summary>
    ///     Provides logic for raising and handling domain events.
    /// </summary>
    public static class XCareEvents
    {
        [ThreadStatic] private static List<Delegate> _actions;

        private static List<Delegate> Actions
        {
            get { return _actions ?? (_actions = new List<Delegate>()); }
        }

        /// <summary>
        ///     Rejestruje prcedure obsługi zdarzenia.
        /// </summary>
        /// <param name="callback">Procedura osbługi zdarzenia.</param>
        /// <returns></returns>
        public static IDisposable Register<T>(Action<T> callback)
        {
            Actions.Add(callback);
            return new DomainEventRegistrationRemover(() => Actions.Remove(callback));
        }

        /// <summary>
        ///     Sygnalizuje zdarzenie.
        /// </summary>
        public static void Raise<T>(T eventArgs)
        {
            var registeredHandlers = ServiceLocator.Current.GetAllInstances<IEventHandler<T>>();
            foreach (var handler in registeredHandlers)
            {
                handler.Handle(eventArgs);
            }
            foreach (var action in Actions)
            {
                var typedAction = action as Action<T>;
                if (typedAction != null)
                {
                    typedAction(eventArgs);
                }
            }
        }

        /// <summary>
        ///     Klasa pomocnicza.
        /// </summary>
        private sealed class DomainEventRegistrationRemover : IDisposable
        {
            private readonly Action _callOnDispose;

            public DomainEventRegistrationRemover(Action toCall)
            {
                _callOnDispose = toCall;
            }

            public void Dispose()
            {
                _callOnDispose();
            }
        }
    }
}