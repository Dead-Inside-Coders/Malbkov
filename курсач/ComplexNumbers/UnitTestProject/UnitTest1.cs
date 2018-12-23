using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryComplexNumbers;

namespace UnitTestProject 
{
    [TestClass] 
    public class UnitTest1
    {
        [TestMethod] 
        public void TestMethodComplexSum()
        {
            Complex z1 = new Complex(3,2);
            Complex z2 = new Complex(1,1);
            Complex exp_z3 = new Complex(4, 3);

            Complex z3 = z1 + z2;   
               
            Assert.AreEqual(exp_z3.re, z3.re);
            Assert.AreEqual(exp_z3.im, z3.im);
        }
         
        [TestMethod] 
        public void TestMethodComplexSub()
        {
            Complex z1 = new Complex(3, 2); 
            Complex z2 = new Complex(1, 1);  
            Complex exp_z3 = new Complex(2,1); 

            Complex z3 = z1 - z2; 
             
            Assert.AreEqual(exp_z3.re, z3.re);
            Assert.AreEqual(exp_z3.im, z3.im); 
        }

        [TestMethod]
        public void TestMethodComplexMul()
        {
            Complex z1 = new Complex(3, 2);
            Complex z2 = new Complex(1, 1);
            Complex exp_z3 = new Complex(1, 5);

            Complex z3 = z1 * z2;

            Assert.AreEqual(exp_z3.re, z3.re); 
            Assert.AreEqual(exp_z3.im, z3.im);
        } 

        [TestMethod]
        public void TestMethodComplexDiv() 
        { 
            Complex z1 = new Complex(3, 2);  
            Complex z2 = new Complex(1, 1);
            Complex exp_z3 = new Complex(2.5, -0.5);
             
            Complex z3 = z1 / z2;

            Assert.AreEqual(exp_z3.re, z3.re);
            Assert.AreEqual(exp_z3.im, z3.im); 
        }

    } 
}  
 