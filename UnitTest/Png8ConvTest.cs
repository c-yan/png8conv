using Microsoft.VisualStudio.TestTools.UnitTesting;
using png8conv;
using System.IO;

namespace UnitTest
{
    [TestClass]
    public class Png8ConvTest
    {
        [TestMethod]
        public void ConvertToTargetPathTest()
        {
            Assert.AreEqual(".png", Path.GetExtension(Service.ConvertToTargetPath("c:\\test\\test.bmp")));
        }

        [TestMethod]
        public void AvoidCollisionPathTest1()
        {
            Assert.AreEqual("Data\\test[1].png", Service.AvoidCollisionPath("Data\\test.png"));
        }

        [TestMethod]
        public void AvoidCollisionPathTest2()
        {
            Assert.AreEqual("Data\\hoge.png", Service.AvoidCollisionPath("Data\\hoge.png"));
        }
    }
}
