using System;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProducerConsumer;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            BoundedBuffer buffer = new BoundedBuffer(50);

            
            try
            {
                buffer.Add(5);
                
            }
            catch (Exception)
            {
                Assert.Fail("Exception shouldn't have been thrown");
            }
        }

        [TestMethod]

        public void TestTake()
        {
            BoundedBuffer buffer = new BoundedBuffer(50);

            try
            {
                buffer.Take();
            }
            catch (Exception)
            {
                Assert.Fail("Exception shouldn't have been thrown");
            }

        }
    }
}
