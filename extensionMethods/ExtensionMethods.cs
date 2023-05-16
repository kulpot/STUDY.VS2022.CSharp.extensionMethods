using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionMethods
{
    static class ExtensionMethods
    {
        public static int GetSpaceCount(this string instance)
        {
            int count = 0;

            foreach(char c in instance)
            {
                if(c.Equals(' '))
                    count++;
            }

            return count;
        }
    }
}
