using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoConstructorTest.Examples
{

    [NoAutomaticTest]
    public class ExcludedClass
    {
        public ExcludedClass(string s)
        {
        }
    }

}