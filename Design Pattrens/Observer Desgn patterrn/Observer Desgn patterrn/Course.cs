using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Desgn_patterrn
{
   public class Course :Subject
    {
       private string courseName;
       private string avalabilty;
       private List<Observer> observerList;

       public Course(string name)
       {
           this.courseName = name;
           observerList = new List<Observer>();
       }

       public void subscribe(Observer observer)
       {
           observerList.Add(observer);
       }

       public void unsubscribe(Observer observer)
       {
           observerList.Remove(observer);
       }

       public void notifyAllSubscribers()
       {
           foreach (var observer in observerList)
           {
               observer.update(avalabilty);
           }
       }
       public void setAvalibilty(bool avalible  )
       {
           avalabilty = this.courseName + (avalible ? " Available" : " Not Available");
           notifyAllSubscribers();
       }
    }
}
