using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hesapla
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckToplama()
        {
            TDD_ClassLibrary2.Hesapla a = new TDD_ClassLibrary2.Hesapla();
            Assert.AreEqual(2, a.Toplama(1, 1));
        }
        [TestMethod]
        public void CheckÇarpma()
        {
            TDD_ClassLibrary2.Hesapla a = new TDD_ClassLibrary2.Hesapla();
            Assert.AreEqual(2, a.Carpma(2, 1));
        }
        [TestMethod]
        public void CheckCikartma()
        {
            TDD_ClassLibrary2.Hesapla a = new TDD_ClassLibrary2.Hesapla();
            Assert.AreEqual(1, a.Cikarma(2, 1));
        }
        [TestMethod]
        public void CheckBolme()
        {
            TDD_ClassLibrary2.Hesapla a = new TDD_ClassLibrary2.Hesapla();
            Assert.AreNotEqual(1, a.Bolme(0, 3));
        }

    }
}
