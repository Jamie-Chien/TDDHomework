using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDHomework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDHomework.Tests
{
    [TestClass()]
    public class TargetTests
    {
        internal List<Product> Products { get; private set; }

        // 在執行每一項測試之前，先使用 TestInitialize 執行程式碼
        [TestInitialize()]
        public void MyTestInitialize()
        {
            Products = new List<Product>();
            Products.Add(new Product { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            Products.Add(new Product { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            Products.Add(new Product { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            Products.Add(new Product { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            Products.Add(new Product { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            Products.Add(new Product { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            Products.Add(new Product { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            Products.Add(new Product { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            Products.Add(new Product { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            Products.Add(new Product { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            Products.Add(new Product { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });
        }

        [TestMethod()]
        public void Test每3筆一組_取Cost總合()
        {
            //arrange

            //act

            //assert
            Assert.Fail();
        }

        [TestMethod]
        public void Test每4筆一組_取Revenue總合()
        {
            //arrange

            //act

            //asert
            Assert.Fail();
        }
    }
}