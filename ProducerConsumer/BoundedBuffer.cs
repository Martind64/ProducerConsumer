using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class BoundedBuffer 
    {

        private Queue<int> _queue;
        private int _bufferSize;

      
        public BoundedBuffer(int bufferSize)
        {
            if (bufferSize <= 0)
            {
                throw new ArgumentOutOfRangeException("Negative Size: " + bufferSize);
            }
            _bufferSize = bufferSize;
            _queue = new Queue<int>();
        }

        public bool IsFull()
        {
            bool result = _queue.Count == _bufferSize;
            return result;
        }
        public bool IsEmpty()
        {
            bool result = _queue.Count == 0;
            return result;
        }

        
        public void Add(int input)
        {
            if (IsEmpty())
            {
               _queue.Enqueue(input);
            }
        }

        public int Take()
        {
            return _queue.Dequeue();
        }



    }
}
