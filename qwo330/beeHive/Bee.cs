using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeHive
{
    class Bee
    {
        public Bee(double weight)
        {
            this.weight = weight;
        }
        private double weight;
    
        public virtual int ShiftsLeft
        {
            get { return 0; }
        }

        public virtual double GetHoneyConsumption()
        {
            double consumption;
            if (ShiftsLeft == 0) consumption = 7.5;
            else consumption = 9 + ShiftsLeft;

            if (weight > 150) consumption *= 1.35;
            return consumption;
        }
    }
}
