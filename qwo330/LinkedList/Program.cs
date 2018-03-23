using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> sample = new List<int>();
            //sample.Add(16);
            //sample.Add(14);

            //sample.Remove(14);
            //sample.Remove(5);

            //Console.WriteLine(sample.Count().ToString());

            myList my = new myList();
            int select;
            int data;
            while (true)
            {
                Console.Write("\n1 : 추가, 2: 삭제, 3: 탐색, 4: 리스트 출력, 5: Count >>> ");
                int.TryParse(Console.ReadLine(), out select);

                switch(select)
                {
                    case 1: // Add
                        Console.Write("저장할 값은? (int) >>> ");
                        int.TryParse(Console.ReadLine(), out data);
                        my.Add(data);
                        break;
                    case 2: // Remove
                        Console.Write("삭제할 값은? (int) >>> ");
                        int.TryParse(Console.ReadLine(), out data);
                        my.Remove(data);
                        break;
                    case 3: // Contain
                        Console.Write("찾을 값은? (int) >>> ");
                        int.TryParse(Console.ReadLine(), out data);
                        if (my.Find(data) != null) Console.WriteLine("해당 값이 존재합니다.");
                        else Console.WriteLine("해당 값이 존재하지 않습니다.");
                        break;

                    case 4: // print List
                        my.PrintList();
                        break;
                    case 5: // Count
                        Console.WriteLine("현재 List의 데이터 수 " + my.Count().ToString());
                        break;

                    default: break;
                }
            }
        }
    }
}