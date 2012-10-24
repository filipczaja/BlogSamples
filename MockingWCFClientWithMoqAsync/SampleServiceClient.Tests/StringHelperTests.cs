using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleServiceClient.SampleWebService;

namespace SampleServiceClient.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void TestStringHelper_Reverse()
        {
            // Create channel mock
            Mock<IStringServiceChannel> channelMock = new Mock<IStringServiceChannel>(MockBehavior.Strict);

            // setup the mock to expect the Reverse method
            channelMock.Setup(c => c.ReverseStringAsync("abc")).Returns(Task.FromResult("cba"));

            // create string helper and invoke the Reverse method
            StringHelper sh = new StringHelper(channelMock.Object);
            string result = sh.ReverseAsync("abc").Result;
            Assert.AreEqual("cba", result);

            //verify that the method was called on the mock
            channelMock.Verify(c => c.ReverseStringAsync("abc"), Times.Once());
        }

        [TestMethod]
        public void TestStringHelper_Integration()
        {
            StringHelper sh = new StringHelper();
            string result = sh.ReverseAsync("abc").Result;
            Assert.AreEqual("cba", result);
        }
    }
}
