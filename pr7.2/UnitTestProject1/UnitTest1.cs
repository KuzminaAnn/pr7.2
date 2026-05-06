using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pr7._2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodBaseRusShif()
        {
            var page = new PageStart();
            string text = "привет";
            int shift = 2;
            string answer = "сткджф";
            Assert.IsTrue(page.EncryptCaesar(text, shift), answer);
        }
        [TestMethod]
        public void TestMethodBaseEnShif()
        {
            var page = new PageStart();
            string text = "hello";
            int shift = 2;
            string answer = "jgnnq";
            Assert.IsTrue(page.EncryptCaesar(text, shift), answer);
        }
        [TestMethod]
        public void TestMethodHardRusShif()
        {
            var page = new PageStart();
            string text = "акула";
            int shift = 20;
            string answer = "уюжяу";
            Assert.IsTrue(page.EncryptCaesar(text, shift), answer);
        }
        public void TestMethodHardEnShif()
        {
            var page = new PageStart();
            string text = "art";
            int shift = 20;
            string answer = "uln";
            Assert.IsTrue(page.EncryptCaesar(text, shift), answer);
        }
        public void TestMethodMaxRusShif()
        {
            var page = new PageStart();
            string text = "сыр";
            int shift = 33;
            string answer = "сыр";
            Assert.IsTrue(page.EncryptCaesar(text, shift), answer);
        }
        public void TestMethodMaxEnShif()
        {
            var page = new PageStart();
            string text = "cat";
            int shift = 26;
            string answer = "cat";
            Assert.IsTrue(page.EncryptCaesar(text, shift), answer);
        }
        public void TestMethodMinRusShif()
        {
            var page = new PageStart();
            string text = "сыр";
            int shift = 0;
            string answer = "сыр";
            Assert.IsTrue(page.EncryptCaesar(text, shift), answer);
        }
        public void TestMethodMinEnShif()
        {
            var page = new PageStart();
            string text = "cat";
            int shift = 0;
            string answer = "cat";
            Assert.IsTrue(page.EncryptCaesar(text, shift), answer);
        }
        public void TestMethodMaxxRusShif()
        {
            var page = new PageStart();
            string text = "сы.р";
            int shift = 34;
            string answer = "ть.с";
            Assert.IsTrue(page.EncryptCaesar(text, shift), answer);
        }
        public void TestMethodMaxxEnShif()
        {
            var page = new PageStart();
            string text = "ca.t";
            int shift = 26;
            string answer = "db.u";
            Assert.IsTrue(page.EncryptCaesar(text, shift), answer);
        }
        public void TestMethodRusShif()
        {
            var page = new PageStart();
            string text = "абв";
            int shift = 2;
            string answer = "абв";
            Assert.IsFalse(page.EncryptCaesar(text, shift), answer);
        }
        public void TestMethodEnShif()
        {
            var page = new PageStart();
            string text = "abc";
            int shift = 2;
            string answer = "abc";
            Assert.IsFalse(page.EncryptCaesar(text, shift), answer);
        }
        [TestMethod]
        public void TestMethodBaseRusDeshif()
        {
            var page = new PageStart();
            string cipher = "сткджф";
            int shift = 2;
            string answer = "привет";
            Assert.IsTrue(page.DecryptCaesar(cipher, shift), answer);
        }
        [TestMethod]
        public void TestMethodBaseEnDeshif()
        {
            var page = new PageStart();
            string cipher = "jgnnq";
            int shift = 2;
            string answer = "hello";
            Assert.IsTrue(page.DecryptCaesar(cipher, shift), answer);
        }
        [TestMethod]
        public void TestMethodHardRusDeshif()
        {
            var page = new PageStart();
            string cipher = "уюжяу";
            int shift = 20;
            string answer = "акула";
            Assert.IsTrue(page.DecryptCaesar(cipher, shift), answer);
        }
        public void TestMethodHardEnDeshif()
        {
            var page = new PageStart();
            string cipher = "uln";
            int shift = 20;
            string answer = "art";
            Assert.IsTrue(page.DecryptCaesar(cipher, shift), answer);
        }
        public void TestMethodMaxRusDeshif()
        {
            var page = new PageStart();
            string cipher = "сыр";
            int shift = 33;
            string answer = "сыр";
            Assert.IsTrue(page.DecryptCaesar(cipher, shift), answer);
        }
        public void TestMethodMaxEnDeshif()
        {
            var page = new PageStart();
            string cipher = "cat";
            int shift = 26;
            string answer = "cat";
            Assert.IsTrue(page.DecryptCaesar(cipher, shift), answer);
        }
        public void TestMethodMinRusDeshif()
        {
            var page = new PageStart();
            string text = "сыр";
            int shift = 0;
            string answer = "сыр";
            Assert.IsTrue(page.DecryptCaesar(text, shift), answer);
        }
        public void TestMethodMinEnDeshif()
        {
            var page = new PageStart();
            string text = "cat";
            int shift = 0;
            string answer = "cat";
            Assert.IsTrue(page.DecryptCaesar(text, shift), answer);
        }
        public void TestMethodMaxxRusDeshif()
        {
            var page = new PageStart();
            string text = "ть.с";
            int shift = 34;
            string answer = "сы.р";
            Assert.IsTrue(page.DecryptCaesar(text, shift), answer);
        }
        public void TestMethodMaxxEnDeshif()
        {
            var page = new PageStart();
            string text = "db.u";
            int shift = 26;
            string answer = "ca.t";
            Assert.IsTrue(page.DecryptCaesar(text, shift), answer);
        }
        public void TestMethodRusDeshif()
        {
            var page = new PageStart();
            string cipher = "абв";
            int shift = 2;
            string answer = "абв";
            Assert.IsFalse(page.DecryptCaesar(cipher, shift), answer);
        }
        public void TestMethodEnDeshif()
        {
            var page = new PageStart();
            string cipher = "abc";
            int shift = 2;
            string answer = "abc";
            Assert.IsFalse(page.DecryptCaesar(cipher, shift), answer);
        }
    }
}
