using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Duplicator
    {
        private BoundedBuffer _ingoingBuffer;
        private BoundedBuffer _outgoingBuffer;
        private BoundedBuffer _outgoingBuffer2;

        public Duplicator(BoundedBuffer ingoingBuffer, BoundedBuffer outgoingBuffer, BoundedBuffer outgoingBuffer2)
        {
            _ingoingBuffer = ingoingBuffer;
            _outgoingBuffer = outgoingBuffer;
            _outgoingBuffer2 = outgoingBuffer2;
        }


    }
}
