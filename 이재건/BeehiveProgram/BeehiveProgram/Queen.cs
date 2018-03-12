using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveProgram
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers) : base(275)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;

            return false;
        }
        public string WorkTheNextShift()
        {
            double totalConsumption = 0;
            for (int i = 0; i < workers.Length; i++)
                totalConsumption += workers[i].GetHoneyConsumption();
            totalConsumption += GetHoneyConsumption();


            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                    report += "Worker #" + (i + 1) + " is doing " + workers[i].CurrentJob
                                + "for " + workers[i].ShiftsLeft + " more shifts\r\n";
                else
                    report += "Worker #" + (i + 1) + " will be done with " + workers[i].CurrentJob +
                            " after this shift\r\n";

            }
            report += "Today honey consumption " + totalConsumption + " units";

            return report;
        }

        public override double GetHoneyConsumption()
        {
            double consumption = 0;
            double largestWorkerConsumption = 0;
            int DoingJobWorkerNumber = 0;

            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].GetHoneyConsumption() > largestWorkerConsumption)
                    largestWorkerConsumption = workers[i].GetHoneyConsumption();

                if (workers[i].ShiftsLeft > 0)
                    DoingJobWorkerNumber++;
            }

            consumption += largestWorkerConsumption;
            if (DoingJobWorkerNumber >= 3)
                consumption += 30;
            else
                consumption += 20;

            return consumption;

        }




    }
}
