using System;
using _283.Move_Zeroes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution sln = new Solution();
            int[] testData = new int[] { 0, 1, 0, 3, 12 };
            sln.MoveZeroes(testData);
            int[] ans = new int[] { 1, 3, 12, 0, 0 };
            Assert.AreEqual(JsonConvert.SerializeObject(testData), JsonConvert.SerializeObject(ans));


        }
    }
}
