using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryRecursionMethods;

namespace UnitTestProject
{ 
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_FibRec()  //2 число Фиб = 1
        {
            int n = 2;  
            int expected_output = 1; 
             
            Fibonachi fib = new Fibonachi();

            int output = fib.FibRec(n);

            Assert.AreEqual(expected_output,output);
        } 
           
        [TestMethod] 
        public void TestMethod_FibLoop()  //12 число Фиб = 144
        { 
            int n = 12;  
            int expected_output = 144;  
             
            Fibonachi fib = new Fibonachi();   
              
            int output = fib.FibLoop(n);  
               
            Assert.AreEqual(expected_output, output);
        }
          
        [TestMethod]
        public void TestMethod_Not_2Zero() // все 2ух разрядные(90)
        {   
            int n = 2;                                                                                                            
            int k = 10;   
            long expected_output = 90; 
              
            long output = ZeroLib.Not_2Zero(n,k);  

            Assert.AreEqual(expected_output, output);
        } 
         
        [TestMethod] 
        public void TestMethod_Zero_end() //10,20 .. 90 (9)
        {   
            int n = 2;     
            int k = 10; 
            long expected_output = 9; 
             
            long output = ZeroLib.Zero_end(n, k);

            Assert.AreEqual(expected_output, output); 
        }    
          
        [TestMethod] 
        public void TestMethod_No_Zero_end()  //все двухразрядные (90) кроме 10,20..90(9)
        {
            int n = 2;  
            int k = 10;
            long expected_output = 81; 
             
            long output = ZeroLib.No_Zero_end(n, k); 
             
            Assert.AreEqual(expected_output, output); 
        }
           
        [TestMethod]  
        public void TestMethod_Stairs()  // 1) 2 - 2  2) 1 - 1 - 1 -1 3) 1 - 2 - 1 4) 2 - 1 - 1 5) 1 - 1 - 2
        { 
            int N = 4;
            int K = 2;  
            ulong expected_output = 5; 
              
            Tasks task = new Tasks();
            ulong output = task.Stairs(N, K);

            Assert.AreEqual(expected_output, output); 
        }
                                                                    
        [TestMethod]
        public void TestMethod_Chairs() //(1-2-3) 1) 2-3-1 2) 3-1-2 
        { 
            int N = 3; 
            int expected_output = 2;

            Tasks task = new Tasks(); 
            int output = task.Chairs(N);

            Assert.AreEqual(expected_output, output);
        }
         
        [TestMethod] 
        public void TestMethod_HappyTicket() // 00,11,22,33..99 (10)
        { 
            int N = 2; 
            long expected_output = 10; 

            Tasks task = new Tasks(); 
            long output = task.HappyTicket(N); 

            Assert.AreEqual(expected_output, output); 
        }
    }
}
