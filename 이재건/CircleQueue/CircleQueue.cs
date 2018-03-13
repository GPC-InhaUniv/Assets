using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleQueue
{
    class CircleQueue
    {
        public static int MAXQUEUESIZE = 6;    //data segement 저장 
        public static int Startpos;
        public static int Nextpos;

        int[] circlequeue;


        public void InitQueue()
        {
            circlequeue = new int[MAXQUEUESIZE];  //heap 에 저장
            for (int i = 0; i < MAXQUEUESIZE; i++)
            {

                circlequeue[i] = new int();
                circlequeue[i] = 0;
            }
            Startpos = 0;
            Nextpos = Startpos;

        }

        public void ResetQueueSize()
        {
            Console.WriteLine("다시 설정할 사이즈를 입력해 주세요: (정수값만)");
            string readline = Console.ReadLine();
            MAXQUEUESIZE = Convert.ToInt32(readline);
            InitQueue();

        }
        public string Dequeue()
        {
            string temp = "";
            if (circlequeue[Startpos] != 0)
            {
                temp = "Dequeue Button Clicked- " + GetStartposValue() + " deleted! and Current StartPosPosition " + CircleQueue.Startpos;
                circlequeue[Startpos] = 0;

                Startpos++;
                if (Startpos == MAXQUEUESIZE)
                    Startpos = 0;

            }
            else
            {
                temp = "There is no data for delete...";
            }
            setEnqeuePosition();
            return temp;


        }

        private void setEnqeuePosition()
        {

        }

        public int GetStartposValue()
        {
            return circlequeue[Startpos];
        }

        public string ShowQueueInfo()
        {
            string temp = "";
            for (int i = 0; i < MAXQUEUESIZE; i++)
            {
                temp += "[" + circlequeue[i] + "]";

            }

            return temp;

        }

        public bool Enqueue(int value)
        {

            if (circlequeue[Nextpos] == 0)
            {
                circlequeue[Nextpos] = value;
                if (Nextpos + 1 < MAXQUEUESIZE)
                    Nextpos++;
                return true;
            }
            else
                return findEnqueuePos(value);

        }

        public bool findEnqueuePos(int value)
        {
            bool exitpoiont = false;
            int position = Nextpos;

            while (!exitpoiont)
            {


                position++;
                if (position >= MAXQUEUESIZE)
                    position = 0;

                if (circlequeue[position] == 0)
                {
                    Nextpos = position;
                    exitpoiont = true;
                    circlequeue[Nextpos] = value;
                    Nextpos++;



                }
                else if (position == Nextpos)
                {
                    Nextpos = position;
                    break;
                }
            }
            return exitpoiont;

        }


    }
}
