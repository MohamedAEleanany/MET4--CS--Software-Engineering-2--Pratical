using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test___Car_Example
{
   public class Car
    {
       public int speed  { get; set; }  
       public bool EngineAreWorking {get ; set ;}
       public String Direction { get; set; }  

       public void DirectionTo()
       {
        speed = 29000;
        EngineAreWorking = true;
        Direction = "To Cairo";
       
       }


    }
}
