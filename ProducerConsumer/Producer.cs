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

        private BoundedBuffer _buffer;
        private int _howMany;
        public static int _lastElement = -1;


        public Producer(BoundedBuffer buffer, int howMany)
        {
            if (buffer == null){throw new ArgumentNullException("Buffer");}
            if (howMany < 0){throw new ArgumentOutOfRangeException("howMany", howMany, "howMany must be a positive number");}
            _buffer = buffer;
            _howMany = howMany;
        }

        public void Run()
        {

            for (int i = 0; i < _howMany; i++)
            {
                _buffer.Add(i);
                Console.WriteLine("Producer Added " + i);
            }

            
        }


    }
}
