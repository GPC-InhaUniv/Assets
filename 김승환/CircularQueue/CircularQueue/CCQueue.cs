using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    public class CircularQueue<T> where T : new()
    {
        private List<T> Nodes = new List<T>();
        private int capacity = 0;
        private int header = 0;
        private int trailer = 0;

        public int Capacity { get { return capacity; } }
        public int Header { get { return header; } }
        public int Trailer { get { return trailer; } }
        public T HeaderData { get { return Nodes[header]; } }
        public T TrailerData { get { return Nodes[Trailer - 1]; } }


        public CircularQueue(int Capacity = 0)
        {
            if (Capacity > 0)
            {
                Initialize(Capacity);
            }
        }


        public int Reallocate(int capacity)
        {
            this.capacity += capacity;

            for (int i = 0; i < capacity; i++)
            {

                Nodes.Add(new T());
            }

            return capacity;
        }


        public void Initialize(int capacity)
        {
            this.capacity = capacity;

            for (int i = 0; i < this.capacity + 1; i++)
            {

                Nodes.Add(new T());
            }
        }


        public void PushBack(T data)
        {
            int nCount = Count;
            if (IsFull)

            {
                Reallocate(capacity);
            }

            int position = 0;

            if (trailer == capacity)
            {
                trailer = 1;
                position = 0;
            }

            else
            {

                position = trailer;

                trailer++;

            }
            Nodes[position] = data;

        }

        public T PopHeader()
        {
            if (IsEmpty)
            {
                return default(T);
            }

            int position = header;

            if (header == capacity - 1)
            {
                header = 0;
            }
            else
            {
                Nodes[header] = default(T);
                header++;
            }

            return Nodes[position];

        }


        public int Count
        {
            get
            {
                if (header <= trailer)
                {
                    return trailer - header;
                }
                else
                {
                    return (capacity + 1) - header + trailer;
                }
            }

        }

        public bool IsEmpty
        {
            get
            {
                return header == trailer;
            }

        }

        public bool IsFull
        {
            get
            {
                if (header < trailer)
                {
                    return (trailer - header) == capacity;
                }
                else
                {
                    return (trailer + 1) == header;
                }
            }

        }


    }
}
