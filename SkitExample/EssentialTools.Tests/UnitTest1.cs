using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTools.Models;

namespace EssentialTools.Tests
{
    /// <summary>
    ///    Тестирование по патерну arrange/act/assert
    ///  Arrange - выставление начальных условий.
    ///  Act - отработка тестируемого функционала.
    ///  Assert - сверка ожидаемых значений с полученными.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        private IDiscountHelper getTestObject()
        {

            return new MinimumDiscountHelper();
        }
        /// <summary>
        /// Если общая сумма превышает $100, скидка составит 10 процентов
        /// </summary>
        [TestMethod]
        public void Discount_Above_100()
        {
            //arrange
            IDiscountHelper target = getTestObject();
            decimal total = 200;
            //act
            var discountedTotal = target.ApplyDiscount(total);
            //assert
            Assert.AreEqual(total * 0.9M, discountedTotal);
        }

        /// <summary>
        ///  Если общая сумма составляет от $10 до $100 включительно, скидка будет $5
        /// </summary>
        [TestMethod]
        public void Discount_Between_10_And_100()
        {
            // arrange
            IDiscountHelper target = getTestObject();
            // act
            decimal TenDollarDiscount = target.ApplyDiscount(10);
            decimal HundredDollarDiscount = target.ApplyDiscount(100);
            decimal FiftyDollarDiscount = target.ApplyDiscount(50);
            // assert
            Assert.AreEqual(5, TenDollarDiscount, "$10 discount is wrong");
            Assert.AreEqual(95, HundredDollarDiscount, "$100 discount is wrong");
            Assert.AreEqual(45, FiftyDollarDiscount, "$50 discount is wrong");
        }
      
        /// <summary>
        /// Для общей суммы меньше $10 скидки не будет 
        /// </summary>
        [TestMethod]
        public void Discount_Less_Than_10()
        {
            //arrange
            IDiscountHelper target = getTestObject();
            //act
            decimal discount5 = target.ApplyDiscount(5);
            decimal discount0 = target.ApplyDiscount(0);
            //assert
            Assert.AreEqual(5, discount5);
            Assert.AreEqual(0, discount0);
        }
        
        /// <summary>
        /// Если общая сумма является отрицательным числом, выбрасывается исключение ArgumentOutOfRangeException 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Discount_Negative_Total()
        {
            //arrange
            IDiscountHelper target = getTestObject();
            //act
            decimal negative = -1;
            //assert
            target.ApplyDiscount(-1);
        }
    }
}
