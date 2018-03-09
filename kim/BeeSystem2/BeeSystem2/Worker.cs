using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeSystem2
{
    class Worker : Bee
    {
        public string CurrentJob = null;
        

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        

        public Worker(string[] jobsICanDo,int Weight)
        {
            this.jobsICanDo = jobsICanDo;
            this.Weight = Weight;
            ConsumHoney = GetHoneyConsumption();
           
        }

        public bool DoThisJob(string orderJob, int totalWorkTime)
        {
            if (!String.IsNullOrEmpty(CurrentJob))
                return false;
            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (jobsICanDo[i] == orderJob)
                {
                    CurrentJob = orderJob;
                    shiftsToWork = totalWorkTime;
                    shiftsWorked = 0;
                    return true;
                }
            }

            return false;

        }

        public bool WorkOneShift()
        {
            if (CurrentJob == null)
                return false;
            shiftsWorked++;
            ShiftsLeft++;
            if(shiftsWorked > shiftsToWork)
            {
                shiftsToWork = 0;
                shiftsWorked = 0;
                ShiftsLeft = 0;
                CurrentJob = null;
                return true;
            }
            return false;
        }

    }
}
