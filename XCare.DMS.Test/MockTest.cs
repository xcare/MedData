using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Bogus;
using Dapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using XCare.DMS.Uploading.Data.Mock;

namespace XCare.DMS.Test
{
    [TestClass]
    public class MockTest
    {
        [TestMethod]
        public void TestFakeBryzxx()
        {
                   
        }

        [TestMethod]
        public void TestFakeBrzd()
        {

        }

        [TestMethod]
        public void TestFakeJcbg()
        {

        }

        [TestMethod]
        public void TestFakeJybg()
        {

        }

        [TestMethod]
        public void TestFakeTwd()
        {
            var twds = YdhlTwdMock.Mock();
            Console.WriteLine(twds);
        }

        [TestMethod]
        public void TestFakeJbxx()
        {
            var jbxxes = YdhlJbxxMock.GetFaker().Generate(20);
            Console.WriteLine(JsonConvert.SerializeObject(jbxxes));
        }
    }

    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Score { get; set; }
        public int Grade { get; set; }
        public bool Side { get; set; }
        public List<Book> Books { get; set; } 
    }

    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
