using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableBill_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            CableBill january = new CableBill(4);
            Console.WriteLine(january.CalcylateAmount(7).ToString());


        }
    }
}
