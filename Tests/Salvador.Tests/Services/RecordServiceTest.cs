using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Salvador.Interface.Services;
using Salvador.Service;

namespace Salvador.Tests.Services
{
    [TestClass]
    public class RecordServiceTest
    {
        private Mock<IRecordService> _recordServiceMok;
        private IRecordService _recordService;

        [TestInitialize]
        public void TestInitialize()
        {
            _recordServiceMok = new Mock<IRecordService>();

            //_recordService = new RecordService();
        }

        [TestMethod]
        public void RecordService_AddToRecord()
        {
            _recordService.AddToRecord();
        }
    }
}
