using System;
using NUnit.Framework;
using GithubActionsLab;

namespace Tests
{
    [TestFixture]
    public class MathOperationsTests
    {
        // Add Tests
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(7, Program.Add("3", "4"));
            Assert.AreEqual(0, Program.Add("0", "0"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("one", "2"));
            Assert.Throws<FormatException>(() => Program.Add("two", "three"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
        }

        // Subtract Tests
        [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(-1, Program.Subtract("1", "2"));
            Assert.AreEqual(1, Program.Subtract("5", "4"));
            Assert.AreEqual(0, Program.Subtract("2", "2"));
        }

        [Test]
        public void Subtract_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("one", "2"));
            Assert.Throws<FormatException>(() => Program.Subtract("four", "five"));
        }

        [Test]
        public void Subtract_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
        }

        // Multiply Tests
        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(2, Program.Multiply("1", "2"));
            Assert.AreEqual(20, Program.Multiply("5", "4"));
            Assert.AreEqual(0, Program.Multiply("0", "2"));
        }

        [Test]
        public void Multiply_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("one", "2"));
            Assert.Throws<FormatException>(() => Program.Multiply("six", "seven"));
        }

        [Test]
        public void Multiply_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
        }

        // Divide Tests
        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(0.5, Program.Divide("1", "2"));
            Assert.AreEqual(1.25, Program.Divide("5", "4"));
            Assert.Throws<DivideByZeroException>(() => Program.Divide("1", "0"));
        }

        [Test]
        public void Divide_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Divide("one", "2"));
            Assert.Throws<FormatException>(() => Program.Divide("eight", "nine"));
        }

        [Test]
        public void Divide_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
        }

        // Power Tests
        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(1, Program.Power("1", "2"));
            Assert.AreEqual(16, Program.Power("2", "4"));
            Assert.AreEqual(1, Program.Power("3", "0"));
        }

        [Test]
        public void Power_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Power("one", "2"));
            Assert.Throws<FormatException>(() => Program.Power("two", "three"));
        }

        [Test]
        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
        }
    }
}
