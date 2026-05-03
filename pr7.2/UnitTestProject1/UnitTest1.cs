using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pr7._2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodBaseRus()
        {
            var page = new PageStart();
            string text = "привет";
            int shift = 2;
            string answer = "сткджф";
            Assert.IsTrue(page.EncryptCaesar(string text, int shift), answer);
        }
        [TestMethod]
        public void TestMethodBaseEn()
        {
            var page = new PageStart();
            string text = "hello";
            int shift = 2;
            string answer = "jgnnq";
            Assert.IsTrue(page.EncryptCaesar(string text, int shift), answer);
        }
        [TestMethod]
        public void TestMethodHardRus()
        {
            var page = new PageStart();
            string text = "акула";
            int shift = 20;
            string answer = "уюжяу";
            Assert.IsTrue(page.EncryptCaesar(string text, int shift), answer);
        }
        public void TestMethodHardEn()
        {
            var page = new PageStart();
            string text = "art";
            int shift = 20;
            string answer = "uln";
            Assert.IsTrue(page.EncryptCaesar(string text, int shift), answer);
        }
        public void TestMethodMaxRus()
        {
            var page = new PageStart();
            string text = "сыр";
            int shift = 33;
            string answer = "сыр";
            Assert.IsTrue(page.EncryptCaesar(string text, int shift), answer);
        }
        public void TestMethodMaxEn()
        {
            var page = new PageStart();
            string text = "cat";
            int shift = 26;
            string answer = "cat";
            Assert.IsTrue(page.EncryptCaesar(string text, int shift), answer);
        }
        public void TestMethodRus()
        {
            var page = new PageStart();
            string text = "абв";
            int shift = 2;
            string answer = "абв";
            Assert.IsFalse(page.EncryptCaesar(string text, int shift), answer);
        }
        public void TestMethodEn()
        {
            var page = new PageStart();
            string text = "abc";
            int shift = 2;
            string answer = "abc";
            Assert.IsFalse(page.EncryptCaesar(string text, int shift), answer);
        }
    }
}
