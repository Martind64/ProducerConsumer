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
        public void TestAddTake()

        {
            BoundedBuffer buffer = new BoundedBuffer(2);

            Assert.AreEqual(4, buffer);

            try
            {
                buffer.Add(2);
                Assert.AreEqual(4, buffer);
            }
            catch (Exception)
            {
                Assert.Fail("Exception shouldn't have been thrown");
            }


        }



    }
}

