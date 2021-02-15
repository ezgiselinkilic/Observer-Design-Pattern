using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public interface IObserver
    {
        void update(CallPublisher publisher);
        void notify(string message, Func<object, int> list1, Func<object, int> list2, Func<object, int> list3,List<string> liste);
    }
}
