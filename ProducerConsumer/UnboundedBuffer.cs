﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class UnboundedBuffer
    {
        private Queue<int> _queue;
        private readonly int _bufferSize;

        public int BufferSize
        {
            get { return _bufferSize; }
        }

      public UnboundedBuffer(int bufferSize)
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
            _queue.Enqueue(input);
            

            _queue.Enqueue(input);
        }

        public int Take()
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
}
