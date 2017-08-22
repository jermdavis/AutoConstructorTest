using System;

namespace AutoConstructorTest.Examples
{

    public class ValidClass2
    {
        public ValidClass2(string s1, ISomeInterface i)
        {
            if (s1 == null)
            {
                throw new ArgumentNullException(nameof(s1));
            }
            if (i == null)
            {
                throw new ArgumentNullException(nameof(i));
            }
        }

        public ValidClass2(string s1, string s2, ISomeInterface i)
        {
            if (s1 == null)
            {
                throw new ArgumentNullException(nameof(s1));
            }
            if (s2 == null)
            {
                throw new ArgumentNullException(nameof(s2));
            }
            if (i == null)
            {
                throw new ArgumentNullException(nameof(i));
            }
        }
    }

}