using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ObjectPool
    {
        private readonly List<Resourse> items = new List<Resourse>();
        private int counter = 0;
        private int number = 0;
        private int MAX = 10;

        public void Release(Resourse item)
        {
            if (counter < MAX)
            {
                items.Add(item); // 사용하지 않는 자원 다시 반환
                counter++;
                Console.WriteLine(item.Pid + " 번째 자원을 반환합니다.");
            }
            else Console.WriteLine("메모리가 부족합니다.");
        }

        public Resourse Get()
        {
            Resourse item;
            if (items.Count != 0)
            {
                item = items.ElementAt(0);
                items.RemoveAt(0);
                counter--;
                Console.WriteLine(item.Pid + " 번째 자원을 얻어옵니다.");
                return item;
            }
            else
            {
                Resourse obj = new Resourse(number++);
                Console.WriteLine("새로운 자원 " + obj.Pid + "를 생성합니다.");
                return obj;
            }
        }
    }
}
