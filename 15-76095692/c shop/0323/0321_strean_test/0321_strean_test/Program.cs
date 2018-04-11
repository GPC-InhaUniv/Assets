using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _0321_strean_test
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StreamWriter sw = new StreamWriter(@"c:\secret_plan.txt");
            sw.WriteLine("how i'll defeat captain amazing");
            sw.WriteLine("2번째줄 writeLine  ㅇㅁㄹㅇㄹ배ㅑㅓㅁㄴㅇ");
            sw.Write("3번째줄 write");
            sw.WriteLine("4번째줄 writeLine  ㅇfadgqerqefw");
            string location = "the mall";
            for (int num = 0; num <= 6; num++)
            {
                sw.WriteLine("Clone#{0} attacks {1}", num, location);
                if (location == "the mall") { location = "downtown"; }
                else { location = "the mall"; }
            }
            sw.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            
        }
    }
}
