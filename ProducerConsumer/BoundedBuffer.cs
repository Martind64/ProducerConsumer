using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class BoundedBuffer : AbstractBuffer, IBuffer 
    {
        
        private Queue<int> _queue;
        private readonly int _bufferSize;

        public int BufferSize
        {
            get { return _bufferSize; }
        }

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

        
        public override void Add(int input)
        {
            Monitor.Enter(_queue);
            if (IsFull())
            {
                Monitor.Wait(_queue);
            }
            

            _queue.Enqueue(input);
        }

        public override int Take()
        {
            Monitor.Enter(_queue);

            while (IsEmpty())
            {
                Monitor.Wait(_queue);
            }

            return _queue.Dequeue();

        }



    }
}
