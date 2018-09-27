using DLLGramtoOunces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DLLGramsToOuncesUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        Class1 c = new Class1();
        [TestMethod]
        public void ConvertToGramsTestMethod()
        {
            double a = c.ConvertToGrams(2);
     
            Assert.AreEqual(56.699, a,0.001);

        }
        [TestMethod]
        public void ConvertToOzTestMethod()
        {

            double a = c.ConvertToOunces(1);

            Assert.AreEqual(0.035,a, 0.001);
    
           

        }
    }
}
