using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmarkverify
{
    public class StringVerify
    {
        private const string someString = "Hello World!";
        public string GetStringSubString()
        {
            return someString.Substring(0, 5);
        }

        public ReadOnlySpan<char> GetStringSpan()
        {
            ReadOnlySpan<char> span = someString.AsSpan();
            return span.Slice(0, 5);
        }
    }
}
