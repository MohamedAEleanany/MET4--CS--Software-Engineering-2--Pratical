using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Desgn_patterrn
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ali = new Student("ali");
            Student ahmed = new Student("ahmed");
            Student mohamed = new Student("mohamed");

            Course java = new Course("Java");
            java.subscribe(ali);
            java.subscribe(ahmed);

            java.setAvalibilty(true);

            java.notifyAllSubscribers();

            java.unsubscribe(ali);

            java.notifyAllSubscribers();

        }
    }
}
