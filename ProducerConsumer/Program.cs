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
            BoundedBuffer buffer = new BoundedBuffer(3);
            Producer p = new Producer(buffer, 5);
            Consumer c = new Consumer(buffer);
            Thread pThread = new Thread(p.Run);
            Thread cThread = new Thread(c.Run);
            pThread.Start();
            cThread.Start();



        }
    }
}
 