using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Consumer
    {

        private BoundedBuffer _buffer;
        
        public Consumer(BoundedBuffer Buffer)
        {
            if (Buffer == null) { throw new ArgumentNullException("Buffer"); }
            
            _buffer = Buffer;
            
        }

        

        public void Run()
        {
            while (true)
            {
                int element = _buffer.Take();

                if (element == Producer._lastElement)
                {
                    break;
                }

                Console.WriteLine("Consumer consumed " + element);
            }
            
        }
    }
}
