using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class MiddleMan
    {
        private BoundedBuffer _outgoingBuffer;
        private BoundedBuffer _ingoingBuffer;

        public MiddleMan(BoundedBuffer ingoingBuffer, BoundedBuffer outgoingBuffer)
        {
            _ingoingBuffer = ingoingBuffer;
            _outgoingBuffer = outgoingBuffer;
        }



    }
}
