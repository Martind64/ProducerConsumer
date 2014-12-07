using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuffer buffer = new BoundedBuffer(100);
            Producer p = new Producer(buffer, 10);
            Consumer c = new Consumer(buffer, 10);

            Thread pThread = new Thread(p.Run);
            Thread cThread = new Thread(c.Run);
        }
    }
}
 