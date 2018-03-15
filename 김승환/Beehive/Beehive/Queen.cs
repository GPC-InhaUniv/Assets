using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public int ShiftNumber { get => shiftNumber; set => shiftNumber = value; }

        public bool AssignWork(string job, int time)
        {
            foreach(Worker w in workers)
            {
                if (w.DothisJob(job, time))
                {
                    return true;
                }
            }
            return false;
        }
        
        public string WorkNextShift()
        {
            shiftNumber++;
            string text = shiftNumber + "번째 리포트\r\n";
            foreach(Worker w in workers)
            {
                if (w.WorkOneShift())
                {
                    text += w.WorkerNumber + "번째 일벌의 작업이 완료 되었습니다\r\n";
                }
                if (string.IsNullOrEmpty(w.CurrentJob))
                {
                    text += w.WorkerNumber + "번째 일벌은 현재 하는 작업이 없습니다\r\n";
                }
                else
                {
                    if(w.ShiftsLeft > 0)
                    {
                        text += w.WorkerNumber + "번째 일벌의 작업이 " + w.ShiftsLeft + "번 남았습니다\r\n";
                    }
                    else
                    {
                        text += w.WorkerNumber + "번째 일벌의 작업이 다음 번에 끝납니다\r\n";
                    }
                }

            }
            return text;
        }

    }
}
