using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class PooledObject
    {
        DateTime creatAt = DateTime.Now; 

        public DateTime CreateAt //객체가 처음 생성된 시간을 보유함.
        {
            get { return creatAt; }
        }

        public string TempData { get; set; }
    }

    public static class Pool
    {
        private static List<PooledObject> available = new List<PooledObject>();
        private static List<PooledObject> inUse = new List<PooledObject>();

        public static PooledObject GetObject()
        {
            lock (available)
            {
                if (available.Count != 0)
                {
                    PooledObject po = available[0];
                    inUse.Add(po);
                    available.RemoveAt(0);
                    return po;
                }
                else
                {
                    PooledObject po = new PooledObject();
                    inUse.Add(po);
                    return po;
                }
            }
        }

        public static void RealeseObject(PooledObject po)
        {
            CleanUp(po);

            lock (available)
            {
                available.Add(po);
                inUse.Remove(po);
            }
        }

        private static void CleanUp(PooledObject po)
        {
            po.TempData = null;
        }
    }
}
