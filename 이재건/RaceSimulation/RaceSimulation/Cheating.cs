using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace RaceSimulation
{
    class Cheating
    {
        private int[] selectedCount;
        private int dognum = -1;

        public Cheating()           //cheating size is 4 , because there are 4 grey hound
        {
            selectedCount = new int[Form1.MAXDOGNUM];
            for (int i = 0; i < Form1.MAXDOGNUM; i++)
                selectedCount[i] = 0;
        }

        public void InitDogForCheat(int selectedDognum)
        {
            if(selectedDognum < 5)                   //increase value(dognumber) if select dog
            selectedCount[selectedDognum - 1]++;       //because dog number range 1~4 so we do -1 when select array
        }
        public int CalculateMaxSelecting()          //calculate func for max selected dog
        {
            int maxSelectedCount = 0;
            
            for(int i=0;i < Form1.MAXDOGNUM; i++)
            {
                for(int j=0;j < Form1.MAXDOGNUM; j++)
                {
                    if (maxSelectedCount < selectedCount[j])   //check most selected dognum
                    {
                        maxSelectedCount = selectedCount[j];
                        dognum = j;
                    }
                }
            }
              
            return dognum;
        }

        public void ResetCheating()
        {
            for (int i = 0; i < Form1.MAXDOGNUM; i++)
                selectedCount[i] = 0;

            dognum = -1;
        }
    }
}
 