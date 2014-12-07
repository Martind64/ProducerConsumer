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

        public Consumer(IBuffer ibuffer, int howMany)
        {
            _iBuffer = ibuffer;
            _howMany = howMany;
        }


        public void Run()
        {
            while (true)
            {
                int element = _iBuffer.Take();
                if (element == Producer._lastElement)
                {
                    break;
                }
                Console.WriteLine("Consumer Take" + element);
            }
            
        }
    }
}
