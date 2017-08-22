using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoConstructorTest.Examples
{

    internal class InternalClass
    {
        private class PrivateClass
        {
            public PrivateClass(string s)
            {
            }
        }

        public InternalClass(string s)
        {
        }
    }

}
