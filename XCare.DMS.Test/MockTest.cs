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
            using (var conn = new SqlConnection(@"Data Source=.\SQL2K8R2;Initial Catalog=Test;Persist Security Info=True;User ID=sa;Password=123;Application Name=xcare"))
            {
                try
                {
                  var obj=  conn.ExecuteScalar<string>(@"
INSERT  INTO dbo.Book ( Id, Name, Price, Author, Subject )
VALUES  ( NEWID(), -- Id - uniqueidentifier
          @_name, -- Name - nvarchar(50)
          @_price, -- Price - money
          @_author, -- Author - nvarchar(50)
          NULL  -- Subject - nvarchar(50)
          )", new {_name = "开发艺术AA", _price = 18, _author = "大A"});
                    Console.WriteLine(obj);
                }
                catch (Exception e)
                {
                    throw e.InnerException;
                }
            }
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
