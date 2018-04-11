using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ObjectPool<MyClass> objPool = new ObjectPool<MyClass>();
            MyClass obj = objPool.Get();
            objPool.Release(obj);
            objPool.Release(obj);
            objPool.Get();
            */

            ObjectPool BulletPool = new ObjectPool();
            Bullet bullet1 = BulletPool.Get();
            BulletPool.ReleaseBullet(bullet1);

            Bullet bullet2 = BulletPool.Get();
            Bullet bullet3 = BulletPool.Get();


            //죄송합니다  실행해보니 Get부분이 조금 이상합니다..//

            Console.Read();
            Console.ReadKey();
        }
    }
    public class ObjectPool
    {
        private int counter = 0;
        private int MAX = 10;
        private readonly List<Bullet> myBullet = new List<Bullet>();


        public void ReleaseBullet(Bullet item)
        {
            if (counter < MAX)
            {
                myBullet.Add(item);
                counter++;
                Console.WriteLine("총알을 다시 가져옵니다.");




            }
        }
        public Bullet Get()
        {
            Bullet item;
            if (myBullet.Count !=0)
            {
                item = myBullet.ElementAt(0);
                myBullet.RemoveAt(0);
                counter--;
                Console.WriteLine("총알을 보관합니다.");

                return item;
            }
            else
            {
                //총알 생성//
                Bullet obj = new Bullet();
    
                myBullet.Add(obj);
                counter++;
                Console.WriteLine("새로운 총알을 생성합니다.");
                return obj;
            }
        }
    }
    public class Bullet
    {
        

    }

}
