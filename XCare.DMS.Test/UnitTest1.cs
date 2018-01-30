using System;
using System.Collections.Generic;
using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using NLipsum.Core;

namespace XCare.DMS.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var bookFaker = new Faker<Book>().StrictMode(false)
                .RuleFor(o => o.Id, Guid.NewGuid)
                .RuleFor(o => o.Name, f => f.Lorem.Sentence(3))
                .RuleFor(o => o.Price, f => Math.Round(f.Random.Double(10, 200), 2));

            var studentFaker = new Faker<Student>().StrictMode(true)
                .RuleFor(o => o.Id, Guid.NewGuid)
                .RuleFor(o => o.Name, f => f.Name.FullName())
                .RuleFor(o => o.Birthday, f => f.Date.Past(100))
                .RuleFor(o => o.Score, f => f.Random.Decimal(0, 100))
                .RuleFor(o => o.Grade, f => f.Random.Int(1, 9))
                .RuleFor(o => o.Side, f => f.Random.Bool())
                .RuleFor(o => o.Books, bookFaker.Generate(10));

           
            Console.WriteLine(JsonConvert.SerializeObject(studentFaker.Generate(100)));
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
