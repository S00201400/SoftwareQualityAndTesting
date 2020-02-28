using System;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;
using WebsiteQualityAndTesting.Functions;


namespace WebsiteQualityAndTesting.Test
{
    [TestFixture]
    public class FunctionsTests
    {
        [Test]
        public void BasicPremiumTest()
        {
            Assert.AreEqual(Functions.Functions.BasicPremium("Comprehensive"), 0.04);
            Assert.AreEqual(Functions.Functions.BasicPremium("Third party"), 0.025);
        }
        [Test]
        public void HandleDriverAgeTest()
        {
            int driverAge = 17;
            double premium = 1;
            bool quotePossible = true;
            Functions.Functions.HandleDriverAge(driverAge, ref premium, ref quotePossible);
            Assert.IsFalse(quotePossible);
            driverAge = 18;
            Functions.Functions.HandleDriverAge(driverAge, ref premium, ref quotePossible);
            Assert.AreEqual(premium, 1.1);
            driverAge = 25;
            Functions.Functions.HandleDriverAge(driverAge, ref premium, ref quotePossible);
            Assert.AreEqual(premium, 1.1);
        }
        [Test]
        public void CheckPenaltyPointsTest()
        {
            int[,] testData = new int[,]
            {
                {1, 4, 100},
                {5, 7, 200},
                {8, 10, 300},
                {11, 12, 400},
            };
            double premium = 0;
            bool quotePossible = true;
            Functions.Functions.CheckPenaltyPoints(0, ref premium, ref quotePossible);
            Assert.IsTrue(quotePossible);
            Assert.AreEqual(premium, 0);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    premium = 0;
                    quotePossible = true;
                    Functions.Functions.CheckPenaltyPoints(testData[i, j], ref premium, ref quotePossible);
                    Assert.IsTrue(quotePossible);
                    Assert.AreEqual(premium, testData[i, 2]);
                }
            }
            premium = 0;
            quotePossible = true;
            Functions.Functions.CheckPenaltyPoints(13, ref premium, ref quotePossible);
            Assert.IsFalse(quotePossible);
            Assert.AreEqual(premium, 0);
        }
    }
}
