using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibilty
{
  public  class Robot
    {
            public string Name { get; set; }

            public Robot(string name)
            {
                Name = name;
            }

            public string IntroduceActivities()
            {
                return "I play Dota, Basketball, and I Draw";
            }
      }
    
}
