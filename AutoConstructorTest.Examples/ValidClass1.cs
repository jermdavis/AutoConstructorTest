using System;

namespace AutoConstructorTest.Examples
{
    public class ValidClass1
    {
        public ValidClass1(string s, int i)
        {
            if(s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
        }

        protected ValidClass1(string s)
        {
        }
    }

}
