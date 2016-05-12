using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_Lesson_1;

namespace UnitTestForComp123
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1_HelloToConsole()
        {
            string expected = "Hello world";
            string result = Program.HelloToConsole();
            Assert.AreEqual(expected, result);
        }
    }
}
