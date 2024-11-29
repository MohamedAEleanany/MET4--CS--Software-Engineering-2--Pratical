using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    public class IRobot
    {
        private IProgrammingLanguage _programmingLanguage;
        public void SetLanguage(IProgrammingLanguage programmingLanguage)
        {
            _programmingLanguage = programmingLanguage;
        }

        public void StartCoding()
        {
            _programmingLanguage.Code();
        }
    }
}
