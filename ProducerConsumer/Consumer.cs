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
        
        public Consumer(BoundedBuffer Buffer)
        {
            if (Buffer == null) { throw new ArgumentNullException("Buffer"); }
            
            _buffer = Buffer;
            
        }

        

        public void Run()
        {
            for (int i = 0; i < _howMany; i++)
            {
                _buffer.Take();
                Console.WriteLine("Consumer Consumes" + i);
            }
                    
            
        }
    }
}
