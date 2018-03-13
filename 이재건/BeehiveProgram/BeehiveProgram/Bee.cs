using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveProgram
{
    class Bee
    {
        public virtual int ShiftsLeft
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }

        private double weight;

        public Bee(double weight)
        {
            this.weight = weight;
        }

        public virtual double GetHoneyConsumption()
        {
            double consumption;
            if (ShiftsLeft == 0)
                consumption = 7.5;
            else
                consumption = 9 + ShiftsLeft;

            if (weight > 150)
                consumption *= 1.5;

            return consumption;
        }
    }
}
