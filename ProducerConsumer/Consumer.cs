using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Consumer
    {
        private BoundedBuffer _buffer;
        private int _howMany;
        public Consumer(BoundedBuffer Buffer, int howMany)
        {
            if (Buffer == null) { throw new ArgumentNullException("Buffer"); }
            if (howMany > 0) { throw new ArgumentOutOfRangeException("howMany", howMany, "howMany must be a positive number"); }
            _buffer = Buffer;
            _howMany = howMany;
        }

        

        public void Run()
        {
            for (int i = 0; i < _howMany; i++)
            {
                _buffer.Take();
                Console.WriteLine("Consumer Take" + i);
            }
                
            
            
        }
    }
}
