using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComarchCwiczenia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComarchCwiczenia.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddShouldReturnSum()
        {
            //Arrange
            int x = 5;
            int y = 10;
            int expected = 15;

            //Act
            int actual = Calculator.Add(x, y);

            //Assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}