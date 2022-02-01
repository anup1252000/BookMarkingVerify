using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmarkverify
{
    public class Maths
    {
        public int Addition(int a, int b) => a + b;

        public int AdditionTryCatch(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }

}
