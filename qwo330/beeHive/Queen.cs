using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeHive
{
    class Queen : Bee
    {
        public Queen(Worker[] workers)
            :base(275) // queen's weight = 275mg
        {
            this.workers = workers;
        }
        private Worker[] workers;
        private int shiftNumber = 0;

        public bool AssignWork(string job, int numberOfShifts)
        {
            for(int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(job, numberOfShifts)) return true;
            }
            return false;
        }

        public string WorkTheNextShift() // work the next shift button
        {
            //tells worker to work and return a shift report to display.
            double totalConsumption = 0;

            for (int i = 0; i < workers.Length; i++)
                totalConsumption += workers[i].GetHoneyConsumption();

            totalConsumption += GetHoneyConsumption();

            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + "\r\n";

            for(int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Worker #" + (i + 1) + " finished the job\r\n";

                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                }
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                        report += "Worker #" + (i + 1) + " is doing '" + workers[i].CurrentJob
                            + "' for " + workers[i].ShiftsLeft + " more shift\r\n";

                    else report += "Worker #" + (i + 1) + " will be done with '"
                            + workers[i].CurrentJob + "' after this shift\r\n";
                }
            }
            report += "Today honey consumption: " + totalConsumption + " units";
            return report;
        }
        public override double GetHoneyConsumption()
        {
            double consumption = 0;
            double largestWorkerConsumption = 0;
            int workersDoingJobs = 0;
            for(int i = 0; i < workers.Length; i++)
            {
                if (workers[i].GetHoneyConsumption() > largestWorkerConsumption)
                    largestWorkerConsumption = workers[i].GetHoneyConsumption();

                if (workers[i].ShiftsLeft > 0) workersDoingJobs++;
            }
            consumption += largestWorkerConsumption;
            if (workersDoingJobs >= 3) consumption += 30;
            else consumption += 20;

            return consumption;
        }
    }
}
