using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HomeworkServices;

namespace HomeWorkService.Tests
{
    [TestClass]
    public class DbServiceTests
    {
        private DbService _service;
        public DbServiceTests()
        {
            var _service = new DbService(new HomeworkDbContext());
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
