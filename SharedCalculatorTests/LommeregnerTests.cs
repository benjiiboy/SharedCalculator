using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculator.Tests
{
    [TestClass()]
    public class LommeregnerTests
    {
        [TestMethod()]
        public void AdditionTest()
        {
            //Arrange
            Lommeregner lm = new Lommeregner();

            //Act
            double result = lm.Addition(2, 2);

            //Assert
            Assert.AreEqual(4, result);

        }

        [TestMethod()]
        public void SubtractionTest()
        {
            //Arrange
            Lommeregner lm = new Lommeregner();

            //Act
            double result = lm.Subtraction(10, 1);

            //Assert
            Assert.AreEqual(9, result);

        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            //Arrange
            Lommeregner lm = new Lommeregner();

            //Act
            double result = lm.Multiplication(3, 3);

            //Assert
            Assert.AreEqual(9, result);

        }

        [TestMethod()]
        public void DivisionTest()
        {
            //Arrange
            Lommeregner lm = new Lommeregner();

            //Act
            double result = lm.Division(4, 2);

            //Assert
            Assert.AreEqual(2, result);

        }

        [TestMethod()]
        public void SqrtTest()
        {
            //Arrange
            Lommeregner lm = new Lommeregner();

            //Act
            double result = lm.Sqrt(9);

            //Assert
            Assert.AreEqual(3, result);

        }
    }
}