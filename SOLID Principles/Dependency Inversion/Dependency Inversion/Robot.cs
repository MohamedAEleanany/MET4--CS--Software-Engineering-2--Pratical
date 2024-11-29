using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    public class Robot
    {
        private JavaLanguage _javaLanguage = new JavaLanguage();
        private CSharpLanguage _cSharpLanguage = new CSharpLanguage();
        public void CodeInJava()
        {
            _javaLanguage.Code();
        }

        public void CodeInCSharp()
        {
            _cSharpLanguage.Code();
        }
    }
}
