using System;
using System.Collections.Generic;
using HomeworkService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWorkService.Tests
{
    [TestClass]
    public class AddArgumentsServiceTests
    {
        private string _paramValues;
       
        [TestMethod]
        public void AddArguments_GiveValues5And10_GetListOfValues_5_10_15()
        {
            //Arrange
            _paramValues = "5/10";

            //Act
            var receivedValue = AddArgumentsService.GetResult(_paramValues);

            //Assert
            Assert.AreEqual(5, receivedValue[0]);
            Assert.AreEqual(10, receivedValue[1]);
            Assert.AreEqual(15, receivedValue[2]);
        }
        
      
        [TestMethod]
        public void AddArguments_GiveValuesMinus999999999And10_GetResultMinus999999989()
        {
            //Arrange
            _paramValues = "-999999999/10";

            //Act
            var receivedValue = AddArgumentsService.GetResult(_paramValues);

            //Assert
            Assert.AreEqual(-999999989, receivedValue[2]);
        }

        [TestMethod]
        public void AddArguments_Give10And5WithSpaces_Get15()
        {
            //Arrange
            _paramValues = "   5   /  10";

            //Act
            var receivedValue = AddArgumentsService.GetResult(_paramValues);

            //Assert
            Assert.AreEqual(15, receivedValue[2]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddArguments_Give10And5SeperatedWithSpaces_GetArgumentException()
        {
            //Arrange
            _paramValues = "   5    10";

            //Act
            var receivedValue = AddArgumentsService.GetResult(_paramValues);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddArguments_GiveStringWithLetters_GetArgumentException()
        {
            //Arrange
            _paramValues = "56/8ok";

            //Act
            var receivedValue = AddArgumentsService.GetResult(_paramValues);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddArguments_GivemoreThanTwoValues_GetArgumentException()
        {
            //Arrange
            _paramValues = "56/8/78/2/4";

            //Act
            var receivedValue = AddArgumentsService.GetResult(_paramValues);
        }
    }
}

