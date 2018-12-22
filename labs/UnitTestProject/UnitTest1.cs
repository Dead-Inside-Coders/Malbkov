using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabsClassLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class ArraySearchTest
    {
        [TestMethod] 
        public void TestMethod1()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int? exp_output = 1;

            int? output = ArraySearch.BinarySearch(arr,2);

            Assert.AreEqual(exp_output, output);
             
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int? exp_output = null; 

            int? output = ArraySearch.BinarySearch(arr, 10);

            Assert.AreEqual(exp_output, output);

        }
         
        [TestMethod]
        public void TestMethod3()
        { 
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 
            int? exp_output = 1;  
               
            int? output = ArraySearch.BinarySearchRec(arr, 0 , arr.Length - 1, 2);

            Assert.AreEqual(exp_output, output);

        }
         
        [TestMethod]  
        public void TestMethod4() 
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int? exp_output = 6;
             
            int? output = ArraySearch.LinearSearch(arr, 7);

            Assert.AreEqual(exp_output, output);
        }

        [TestMethod]
        public void TestMethod5()
        { 
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int? exp_output = null; 

            int? output = ArraySearch.LinearSearch(arr, 10); 

            Assert.AreEqual(exp_output, output);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int? exp_output = 2;

            int? output = ArraySearch.InterpolationSearch(arr, 3);

            Assert.AreEqual(exp_output, output);
        }

        [TestMethod]
        public void TestMethod7()  
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int? exp_output = null;

            int? output = ArraySearch.InterpolationSearch(arr, 10); 

            Assert.AreEqual(exp_output, output);
        }
    }  
    [TestClass]
    public class StrSearch
    {
        [TestMethod] 
        public void TestMethod1()
        {
            string input = "fishing";
            string exp_output = "fish";

            string output = Search.Stemming(input);

            Assert.AreEqual(exp_output, output);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "prealpha"; 
            string exp_output = "alpha";

            string output = Search.Stemming(input);

            Assert.AreEqual(exp_output, output);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input = "disagree";
            string exp_output = "agree";
             
            string output = Search.Stemming(input);

            Assert.AreEqual(exp_output, output);
        }

        [TestMethod]
        public void TestMethod4()
        {  
            string input = "ended";
            string exp_output = "end";

            string output = Search.Stemming(input);

            Assert.AreEqual(exp_output, output);
        }
    }
} 
  