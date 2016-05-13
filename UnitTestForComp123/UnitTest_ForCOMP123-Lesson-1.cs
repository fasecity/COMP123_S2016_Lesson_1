using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_Lesson_1;

namespace UnitTestForComp123
{/**
     * This class is used to test the Lesson 1 Project
     * Used for development only.
     * 
     * @class Lesson1UnitTest
     */
    [TestClass]
    public class UnitTest
    { /**
         * Unit Test for HelloToConsole Method of the Program class
         * 
         * @method Test1_HelloToConsole
         */
        [TestMethod]
        public void Test1_HelloToConsole()
        {
            //arrange
            string expected = "Hello world";
            //act
            string result = Program.HelloToConsole();
            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
