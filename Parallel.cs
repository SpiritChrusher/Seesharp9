using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace SeeSharp9
{
    public class WorkingWithParallel
    {
        static async Task<int> GetText()
        {
            var client = new WebClient();
            string s = await client.DownloadStringTaskAsync("");
            int sum = 0;
            Parallel.ForEach(s, () => 0,					        // thread local initializer
                    (n, loopState, localSum) =>
                    {
                        localSum += (int)n;
                        return localSum;
                    },
                    (localSum) => Interlocked.Add(ref sum, localSum)
                    );
            return sum;
        }

        
    }
}
