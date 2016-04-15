using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Transformers
    {
        public long Square(long x) => x*x;
        public long MultiplyByTwo(long x) => x*2;
        public long OddOrEven(long x) => (long) x%2;
    }
}
