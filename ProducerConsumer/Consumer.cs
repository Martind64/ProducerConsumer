using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Consumer
    {
        private IBuffer _iBuffer;
        private int _howMany;
        public Consumer(IBuffer iBuffer, int howMany)
        {
            if (iBuffer == null) { throw new ArgumentNullException("Buffer"); }
            if (howMany > 0) { throw new ArgumentOutOfRangeException("howMany", howMany, "howMany must be a positive number"); }
            _iBuffer = iBuffer;
            _howMany = howMany;
        }

        

        public void Run()
        {
            for (int i = 0; i < _howMany; i++)
            {
                _iBuffer.Take();
                Console.WriteLine("Consumer Take" + i);
            }
                
            
            
        }
    }
}
