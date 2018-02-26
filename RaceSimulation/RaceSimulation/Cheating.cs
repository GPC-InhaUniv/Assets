using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulation
{
    class Cheating
    {
        int[] selectcount;
        int dognum = -1;

        public Cheating()           //cheating size is 4 , because there are 4 grey hound
        {
            selectcount = new int[4];
            for (int i = 0; i < 4; i++)
                selectcount[i] = 0;
        }

        public void GetCount(int dog)
        {
            if(dog<5)                   //increase value(dognumber) if select dog
            selectcount[dog-1]++;
        }
        public int MaxSelect()          //calculate func for max selected dog
        {
            int max = 0;
            
            for(int i=0;i<4;i++)
            {
                for(int j=0;j<4;j++)
                {
                    if (max < selectcount[j])   
                    {
                        max = selectcount[j];
                        dognum = j;
                    }
                }
            }
            return dognum;
        }

        public void reset()
        {
            for (int i = 0; i < 4; i++)
                selectcount[i] = 0;

            dognum = -1;
        }
    }
}
 