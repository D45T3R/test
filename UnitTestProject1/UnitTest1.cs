using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int minuts = 367;
            decimal need = (decimal)457.2;

            ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();

            decimal final = class1.calc2(minuts);

            Assert.AreEqual(need, final);
        }
        

    }
}
