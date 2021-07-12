using HomeworkService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWorkService.Tests
{
    [TestClass]
    public class AddArgumentsServiceTests
    {
        private string _paramValues;
       
        [TestMethod]
        public void AddArguments_GiveValues5And10_GetResult15()
        {
            //Arrange
            _paramValues = "5 / 10";

            //Act
            var receivedValue = AddArgumentsService.GetResult(_paramValues);

            //Assert
            Assert.AreEqual(15, receivedValue[2]);
        }
        
        [TestMethod]
        public void AddArguments_GiveValuesMinus5And10_GetResult5()
        {
            //Arrange
            _paramValues = "-5 / 10";

            //Act
            var receivedValue = AddArgumentsService.GetResult(_paramValues);

            //Assert
            Assert.AreEqual(5, receivedValue[2]);
        }

        [TestMethod]
        public void AddArguments_GiveValuesMinus999999999And10_GetResultMinus999999989()
        {
            //Arrange
            _paramValues = "-999999999 / 10";

            //Act
            var receivedValue = AddArgumentsService.GetResult(_paramValues);

            //Assert
            Assert.AreEqual(-999999989, receivedValue[2]);
        }
    }
}
