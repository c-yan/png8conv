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
            Assert.IsTrue(Path.GetExtension(Service.ConvertToTargetPath("c:\\test\\test.bmp")) == ".png");
        }
    }
}
