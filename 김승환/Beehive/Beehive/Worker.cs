using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Worker
    {
        private int workerNumber;
        public int WorkerNumber
        {
            get => workerNumber;
            set => workerNumber = value;
        }
        private string currentJob = "";
        public string CurrentJob
        {
            get => currentJob;
        }

        public int ShiftsLeft
        {
            get => shiftsToWork - shiftsWorked;
        }

        private string[] jobsIcanDo;

        private int shiftsToWork;
        public int ShiftsToWork { get => shiftsToWork; set => shiftsToWork = value; }

        private int shiftsWorked;
        public int ShiftsWorked { get => shiftsWorked; set => shiftsWorked = value; }

        public Worker(int num, string[] work)
        {
            workerNumber = num;
            jobsIcanDo = work;
        }

        public bool DothisJob(string job, int shift)
        {
            if (!string.IsNullOrEmpty(currentJob))
            {
                return false;
            }
            foreach (string work in jobsIcanDo)
            {
                if(work == job)
                {
                    currentJob = job;
                    shiftsWorked = 0;
                    shiftsToWork = shift;
                    return true;
                }
            }
            return false;
        }

        public bool WorkOneShift()
        {
            if(string.IsNullOrEmpty(currentJob))
            {
                return false;
            }
            shiftsWorked++;
            if(shiftsWorked > shiftsToWork)
            {
                shiftsToWork = 0;
                shiftsWorked = 0;
                currentJob = "";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
