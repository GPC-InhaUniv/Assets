using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeSystem2
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int weight;
        private double TotalEatHoney = 0;
        public Queen(Worker[] workers,int weight)
        {
            this.workers = workers;
            this.weight = weight;
            
        }

        public bool AssignWork(string orderJob, int totalWorkTime)

        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(orderJob, totalWorkTime))
                {
                    return true;
                }
            }

            return false;
        }
        public string WorkTheNextShift()
        {
            this.ShiftsLeft++;
            ConsumHoney = this.GetHoneyConsumption();
            
            string report= ShiftsLeft + "번째 리포트\r\n";
            for(int i =0; i< workers.Length; i++)
            {
                TotalEatHoney += workers[i].GetHoneyConsumption();
               
            }
            
            for(int i =0; i<workers.Length; i++)
            {
               
                if (workers[i].WorkOneShift())
                {
                    report += (i + 1) + "번째 벌이 일을 끝마쳤습니다.\r\n";
                }
                else
                {
                    if (workers[i].CurrentJob==null)
                        report += (i + 1) + " 번째 벌은 일을 하고 있지 않습니다. \r\n";
                    else
                    {
                        if (workers[i].ShiftsLeft > 0)
                        {
                            report += (i + 1) + "번째 벌이 " + workers[i].CurrentJob + " 일을 하고있습니다. 남은 진행상황 : " + workers[i].ShiftsLeft + "\r\n";
                           
                        }
                    }
                }
            }


            report += "벌들이 총 먹은 꿀의 양 : " + TotalEatHoney + "\r\n";
            return report;
        }

        public override double GetHoneyConsumption()
        {
            double consum = 0;
            int currentworkingbee = 0;
            double MaxConsum = 0;
            for(int i=0; i< workers.Length;i++)
            {
                if(workers[i].GetHoneyConsumption() > MaxConsum)
                {
                    MaxConsum = workers[i].GetHoneyConsumption();
                }
                if(!String.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    currentworkingbee++;
                }
            }
            if (currentworkingbee <= 2)
                consum = MaxConsum + 20;
            else
                consum = MaxConsum + 30;
            currentworkingbee = 0;
            return consum;

        }
    }
}
