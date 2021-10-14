using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdPartyTools;

namespace FileTest
{
    [TestClass]
    public class FileTest
    {
        [TestMethod]
        public void Possitive_prototypeFirst()
        {
            //Chane the input for test
            string[] input = @"-v C:/test.txt".Split(' ');
            bool res = Program.prototypeFirst(input);
            Assert.AreEqual(res, true);
        }
        [TestMethod]
        public void Possitive_prototypeSecond()
        {
            //Chane the input for test
            string[] input = @"--s C:/test.txt".Split(' ');
            bool res = Program.prototypeSecond(input);
            Assert.AreEqual(res, true);
        }
        [TestMethod]
        public void Negative_prototypeFirst()
        {
            //Chane the input for test
            string[] input = @"-t C:/test.txt".Split(' ');           
            bool res = Program.prototypeFirst(input);
            Assert.AreEqual(res, false);
        }
        [TestMethod]
        public void Negative_prototypeSecond()
        {
            //Chane the input for test
            string[] input = @"-g C:/test.txt".Split(' ');
            bool res = Program.prototypeSecond(input);
            Assert.AreEqual(res, false);
        }
    }
}
