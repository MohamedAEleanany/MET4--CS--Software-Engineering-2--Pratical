using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Desgn_patterrn
{
    public interface Subject
    {
        void subscribe(Observer observer);
        void unsubscribe(Observer observer);
        void notifyAllSubscribers();


    }
}
