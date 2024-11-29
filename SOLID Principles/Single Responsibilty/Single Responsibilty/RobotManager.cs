using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibilty
{
    class RobotManager
    {
        public string Name { get; set; }
    private List<object> Activities { get; set; }

    public RobotManager(string name, List<object> activities)
    {
        Name = name;
        Activities = activities;
    }

    public void IntroduceActivities()
    {
        foreach (var activity in Activities)
        {
            Console.WriteLine(((dynamic)activity).Activity());
        }
    }
    }
}
