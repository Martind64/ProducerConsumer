using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public interface IBuffer
    {

        int Count();

        bool IsEmpty();

        int Take();
        void Add(int element);




    }
}
