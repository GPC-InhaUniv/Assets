using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    class Program
    {
        static void Main(string[] args)
        {
            Linked link = new Linked();
            link.Add(1);
            link.Add(2);
            link.Add(3);
            link.Add(4);
            link.Add(5);
            Debug.WriteLine("================" + link.Count);
            link.Print();
            Debug.WriteLine("================" + link.Count);
            link.Delete(3);
            link.Print();
            Debug.WriteLine("================" + link.Count);
            link.AddIndex(3, 3);
            link.Print();
            Debug.WriteLine("================" + link.Count);


            출처: http://herbyoung.tistory.com/74 [Herbyoung - 개발자 블로그]
        }
    }
}
