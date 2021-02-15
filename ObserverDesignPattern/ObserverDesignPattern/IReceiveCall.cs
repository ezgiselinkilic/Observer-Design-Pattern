using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
   public  interface IReceiveCall
    {
        void subscribe(IObserver observer);
        void unsubscribe(IObserver observer);
        void notifychanges();
    }
}
