using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0321_strean_test
{
    class Flobbo
    {
        private string Zap;
        public int i;

        public Flobbo(string Zap)
        {
            this.Zap = Zap;
            i++;
            Console.WriteLine(i);
        }
        public StreamWriter Snobbo()
        {
            return new StreamWriter("macaw"+i+".txt");

        }
        public bool Blobbo(StreamWriter sw)
        {
            sw.WriteLine(Zap);
            Zap = "green purple";
            //sw.Close();
            i++;
            Console.WriteLine(i);
            return false;
        }
        public bool Blobbo(bool Already, StreamWriter sw)//오버라이드
        {
            if (Already)
            {
                sw.WriteLine(Zap);
                i++;
                Console.WriteLine(i);
                sw.Close();
                return false;
            }
            else
            {

                sw.WriteLine(Zap);
                i++;
                Console.WriteLine(i);
                Zap = "red orange";
                return true;//수정값
            }
            
        }

        
    }
}
