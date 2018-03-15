using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularQueue
{
    class QueueBody
    {
        private int[] array;
        private int front;
        private int rear;
        private int count;
        private int maxIndex;


        public QueueBody(int size)
        {
            array = new int[size];
            front = 0;
            rear = -1;
            count = 0;
            maxIndex = size;
        }

        public void InputNumber(int Input) // Index에 채울 입력내용
        {
            if (count == maxIndex)
            {
                Console.WriteLine("공간이 모두 찼습니다.");
                return;
            }
            else
            {
                rear = (rear+1) % maxIndex;
                array[rear] = Input;
                count++;
            }
        }

        public void DeleteNumber()
        {
            if (count == 0)
            {
                Console.WriteLine("빼낼 숫자가 없습니다.");
            }
            else
            {
                Console.WriteLine("비운 Index는" + array[front] + "입니다.");
                front = (front + 1) % maxIndex;
                count--;

            }
        }

        public void WriteResult()
        {
            int i = 0;
            int j = 0;

            if (count == 0)
            {
                Console.WriteLine("공간이 비어있습니다.");
                return;
            }
            else
            {
                for (i = front; j < count;)
                {
                    Console.WriteLine("Input[" + (i + 1) + "]: " + array[i]);

                    i = (i + 1) % maxIndex;
                    j++;

                }
            }
            Console.ReadKey();
        }
    }
}
