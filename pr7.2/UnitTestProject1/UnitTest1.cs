using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pr7._2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodBase()
        {
            var page = new PageStart();
            string text = "привет";
            int shift = 2;
            string answer = "сткджф";
            Assert.IsTrue(page.EncryptCaesar(string text, int shift), answer);
        }
    }
}
