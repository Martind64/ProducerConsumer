using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public abstract class AbstractBuffer
    {
        protected Queue<int> _queue = new Queue<int>();

        public abstract void Add(int input);

        public abstract int Take();

        public bool Count()
        {
            return (_queue.Count <= 0);
        }

        public bool IsEmpty()
        {
            return (_queue.Count <= 0);
        }

    }
}
