using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_WhiteBox_Tests
{
    class Tests
    {
        Program sut;

        [SetUp]
        public void Initialise()
        {
            sut = new Program();
        }
        //[Test]
        //public void Test_CalcPremium_1()
        //{
        //    float actualResult = sut.CalcPremium(20, "female");
        //    Assert.That(actualResult, Is.EqualTo(5.0f));
        //}

        //[Test]
        //public void Test_CalcPremium_2()
        //{
        //    float actualResult = sut.CalcPremium(38, "female");
        //    Assert.That(actualResult, Is.EqualTo(3.5f));
        //}

        //[Test]
        //public void Test_CalcPremium_3()
        //{
        //    float actualResult = sut.CalcPremium(60, "female");
        //    Assert.That(actualResult, Is.EqualTo(1.75f));
        //}


        [TestCase(20, "female", ExpectedResult = 5.0f)]
        [TestCase(38, "female", ExpectedResult = 3.5f)]
        [TestCase(60, "female", ExpectedResult = 1.75f)]
        [TestCase(30, "male", ExpectedResult = 6.0f)]
        [TestCase(46, "male", ExpectedResult = 5.0f)]
        [TestCase(70, "male", ExpectedResult = 2.5f)]
        [TestCase(13, "female", ExpectedResult = 0.0f)]
        [TestCase(16, "male", ExpectedResult = 0.0f)]
        public float Test_CalcPremium_many(int a, string b)
        {
            float actualResult = sut.CalcPremium(a, b);
            return actualResult;
        }
    }
}