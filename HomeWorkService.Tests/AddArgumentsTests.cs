using HomeworkService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWorkService.Tests
{
    [TestClass]
    public class AddArgumentsTests
    {
        private int _param1;
        private int _param2;

        [TestMethod]
        public void AddArguments_GiveSimpleValues_GetCorrectSum()
        {
            //Arrange
            _param1 = 5;
            _param2 = 10;

            //Act
            var receivedValue = AddArguments.GetResult(_param1, _param2);

            //Assert
            Assert.AreEqual(15, receivedValue);
        }
        
        [TestMethod]
        public void AddArguments_GiveNegativeValue_GetCorrectResult()
        {
            //Arrange
            _param1 = -5;
            _param2 = 10;

            //Act
            var receivedValue = AddArguments.GetResult(_param1, _param2);

            //Assert
            Assert.AreEqual(5, receivedValue);
        }

        [TestMethod]
        public void AddArguments_GiveLargeNegativeValue_GetCorrectResult()
        {
            //Arrange
            _param1 = -999999999;
            _param2 = 10;

            //Act
            var receivedValue = AddArguments.GetResult(_param1, _param2);

            //Assert
            Assert.AreEqual(-999999989, receivedValue);
        }

        [TestMethod]
        public void AddArguments_GiveLargeValues_GetException()
        {
            //Arrange
            _param1 = 999999999;
            _param2 = 999999999;

            //Act
            var receivedValue = AddArguments.GetResult(_param1, _param2);

            //Assert
            Assert.AreEqual(1999999998, receivedValue);
        }

    }
}
