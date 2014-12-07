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
        private readonly IBuffer _iBuffer;
        private int _howMany;
        private int _lastElement = -1;

        

        public Producer(IBuffer buffer, int howmany)
        {
            if (buffer == null){throw new ArgumentNullException("buffer");}
            if (howmany > 0){throw new ArgumentOutOfRangeException("howmany", howmany, "howmany must be a positive number");}

            _iBuffer = buffer;
            _howMany = howmany;
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
