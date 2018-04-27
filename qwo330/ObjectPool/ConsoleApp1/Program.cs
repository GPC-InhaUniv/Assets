using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            ObjectPool objPool = new ObjectPool();
            Resourse rs1 = objPool.Get();
            Resourse rs2 = objPool.Get();
            Resourse rs3 = objPool.Get();
            Resourse rs4 = objPool.Get();

            objPool.Release(rs1);
            objPool.Release(rs3);

            Resourse rs5 = objPool.Get();
            objPool.Release(rs4);

            Resourse rs6 = objPool.Get();
            Resourse rs7 = objPool.Get();
            rs1 = objPool.Get();
            rs3 = objPool.Get();

            Console.Read();
        }
    }
}
