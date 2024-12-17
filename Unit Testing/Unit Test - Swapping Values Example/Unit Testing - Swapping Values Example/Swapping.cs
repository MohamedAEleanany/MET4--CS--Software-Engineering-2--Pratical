using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing___Swapping_Values_Example
{
   public class Swapping
    {
     public void swapTwoValues(ref int x , ref int y)
       {
           int temp = x;
           x = y;
           y = temp;
       }

    }
}
