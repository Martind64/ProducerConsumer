using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Producer
    {

        private IBuffer _iBuffer;
        private int _howMany;
        public static int _lastElement = -1;


        public Producer(IBuffer iBuffer, int howMany)
        {
            if (iBuffer == null){throw new ArgumentNullException("Buffer");}
            if (howMany > 0){throw new ArgumentOutOfRangeException("howMany", howMany, "howMany must be a positive number");}
            _iBuffer = iBuffer;
            _howMany = howMany;
        }

        public void Run()
        {

            for (int i = 0; i < _howMany; i++)
            {
                _iBuffer.Add(i);
                Console.WriteLine("Producer Added" + i);
            }

            _iBuffer.Add(_lastElement);
        }


    }
}
