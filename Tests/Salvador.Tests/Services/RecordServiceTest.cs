using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Salvador.Domain.Entities;
using Salvador.Interface.Services;
using Salvador.Service;
using Assert = Xunit.Assert;
using Record = Salvador.Domain.Entities.Record;


namespace Salvador.Tests.Services
{
    [TestClass]
    public class RecordServiceTest
    {

        private List<Record> _records;
        private Mock<IRecordService> _recordServiceMok;
        private IRecordService _recordService;

        [TestInitialize]
        public void TestInitialize()
        {
            //var recordMock = new Mock<IRecordService>();
            //recordMock.Setup(p => p.AddToRecord()).Returns()
            //{

            //}
            _records = new List<Record>()
            {
                new Record()
                {
                    Id = 1,
                    Phone = "89992583378",
                    DateTime = DateTime.Now,
                    Email = "yandex@mail.ru",
                    Name = "Nastoyka",
                },
                new Record()
                {
                    Id = 2,
                    Phone = "88888888888",
                    DateTime = DateTime.Now,
                    Email = "google@mail.ru",
                    Name = "bygylma",
                },
                new Record()
                {
                    Id = 3,
                    Phone = "87777777777",
                    DateTime = DateTime.Now,
                    Email = "mail@mail.ru",
                    Name = "wiski",
                }
            };

            _recordServiceMok = new Mock<IRecordService>();

            //_recordService = new RecordService();
        }

        [TestMethod]
        public void RecordService_GetRecord()
        {
            //const int count = 3;
            //var record = _records;

            //var actualCount = record.Count;
            //_recordService.GetRecord();
            //Assert.Equal(count, actualCount);
        }

        [TestMethod]
        public void RecordService_AddToRecord()
        {
            //_records.Clear();
            //const int id = 2;
            //_recordService.AddToRecord();

            //Assert.Equal(1,_records);
        }
    }
}
