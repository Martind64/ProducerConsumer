using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class BoundedBuffer
    {
        private Queue<int> _queue;
        private int _buffersize;


        public BoundedBuffer(int buffersize)
        {
            _buffersize = buffersize;
            _queue = new Queue<int>();
        }



        public bool IsFull()
        {
            bool result = _queue.Count >= _buffersize; 
            return result;
        }

        public int Take()
        {
            return _queue.Dequeue();
        }

        public void Add(int input)
        {
            if (IsFull())
            {
                _queue.Enqueue(input);
            }
        }


    }
}
