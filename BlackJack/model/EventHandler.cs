using System.Collections.Generic;

namespace BlackJack.model
{
    abstract class EventHandler
    {
        private List<IObserver> m_observers = new List<IObserver>();
        public void AddSubscriber(IObserver a_sub)
        {
            m_observers.Add(a_sub);
        }

        public void NotifySubscribers()
        {
            foreach (IObserver o in m_observers)
            {
                o.CardReceived();
            }
        }
    }
}
