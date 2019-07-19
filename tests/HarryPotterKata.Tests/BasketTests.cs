using HarryPotterKata.Enumerations;
using HarryPotterKata.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HarryPotterKata.Tests
{
    public class BasketTests
    {
        //InlineData(expected value, quantities for each book volume)
        [Theory]
        [InlineData(8,                                          new int[5] { 1, 0, 0, 0, 0 })]
        [InlineData(2 * 8 * 0.95,                               new int[5] { 1, 1, 0, 0, 0 })]
        [InlineData(3 * 8 * 0.9,                                new int[5] { 1, 1, 1, 0, 0 })]
        [InlineData(5 * 8 * 0.75,                               new int[5] { 1, 1, 1, 1, 1 })]
        [InlineData(2 * 8 * 0.95 + 1 * 8,                       new int[5] { 2, 1, 0, 0, 0 })]
        [InlineData(3 * 8 * 0.9 + 1 * 8,                        new int[5] { 2, 1, 1, 0, 0 })]
        [InlineData(4 * 8 * 0.8 + 4 * 8 * 0.8,                  new int[5] { 2, 2, 2, 1, 1 })]
        [InlineData(3 * (8 * 5 * 0.75) + 2 * (8 * 4 * 0.8),     new int[5] { 5, 5, 4, 5, 4 })]
        public void Total_ShouldEqual(double expected, int[] bookVolumeQuantities)
        {
            Basket basket = new Basket();
            for (int i = 0; i < bookVolumeQuantities.Length; i++)
            {
                basket.AddBooks((BookVolumeEnum)(i + 1), bookVolumeQuantities[i]);
            }

            double actual = basket.TotalPrice;

            Assert.Equal(expected, actual);
        }
    }
}
