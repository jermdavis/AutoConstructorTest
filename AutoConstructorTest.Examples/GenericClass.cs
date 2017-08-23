using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoConstructorTest.Examples
{

    public class GenericClass //<T> where T : ISomeInterface
    {
        public GenericClass(List<ISomeInterface> data, string s)
        {
            if(data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            if(s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
        }
    }

}
