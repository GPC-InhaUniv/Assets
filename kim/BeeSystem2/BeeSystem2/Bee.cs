using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeSystem2
{
    class Bee
    {
        public int ShiftsLeft;
        public double ConsumHoney;
        public int Weight;
        
       
        public virtual double GetHoneyConsumption()
        {
            double consum = 0;
            if (ShiftsLeft > 0)
            {
                consum = ShiftsLeft + 9;
                
            }
            else
                consum = 7.5;

            if (Weight > 150)
                consum = consum * 1.35;

            return consum;
        }


    }
}
