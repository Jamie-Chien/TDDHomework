using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDHomework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace TDDHomework.Tests
{
    [TestClass()]
    public class GrouperTests
    {
        private List<Product> Products { get; set; }

        // 在執行每一項測試之前，先使用 TestInitialize 執行程式碼
        [TestInitialize()]
        public void MyTestInitialize()
        {
            var products = new List<Product>()
            {
                new Product() { Id=1 ,Cost=1 ,Revenue=11,SellPrice=21 },
                new Product() { Id=2 ,Cost=2 ,Revenue=12,SellPrice=22 },
                new Product() { Id=3 ,Cost=3 ,Revenue=13,SellPrice=23 },
                new Product() { Id=4 ,Cost=4 ,Revenue=14,SellPrice=24 },
                new Product() { Id=5 ,Cost=5 ,Revenue=15,SellPrice=25 },
                new Product() { Id=6 ,Cost=6 ,Revenue=16,SellPrice=26 },
                new Product() { Id=7 ,Cost=7 ,Revenue=17,SellPrice=27 },
                new Product() { Id=8 ,Cost=8 ,Revenue=18,SellPrice=28 },
                new Product() { Id=9 ,Cost=9 ,Revenue=19,SellPrice=29 },
                new Product() { Id=10,Cost=10,Revenue=20,SellPrice=30 },
                new Product() { Id=11,Cost=11,Revenue=21,SellPrice=31 }
            };
        }

        [TestMethod()]
        public void Test每3筆一組_取Cost總合()
        {
            //arrange
            Grouper target = new Grouper(Products);
            string columnName = "Cost";
            int groupSize = 3;
            var expected = new int[] { 6, 15, 24, 21 };

            //act
            var actual = target.SubTotal(groupSize, columnName);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void Test每4筆一組_取Revenue總合()
        {
            //arrange
            Grouper target = new Grouper(Products);
            string columnName = "Revenue";
            int groupSize = 4;
            var expected = new int[] { 50, 66, 60 };

            //act
            var actual = target.SubTotal(groupSize, columnName);

            //asert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}