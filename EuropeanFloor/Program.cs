using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanFloor
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int GetRealFloor(int n)
        {

            return n <= 0 ? n : n < 13 ? n - 1 : n - 2;
        }
    }
}
