using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmarkverify
{
   
    public class AsyncAwaitVerify
    {
       
        public Task GetTaskAsync()
        {
            return Task.Run(() => Enumerable.Range(1, 100000));
        }

        
      
    }
}
