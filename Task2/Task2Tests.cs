using System.Collections.Generic;
using App.Task2;
using FluentAssertions;
using NUnit.Framework;

namespace Task2
{
    public class Task2Tests
    {
        private List<int> _list;

        [SetUp]
        public void Setup()
        {
            _list = new List<int> { 3, 1, 8, 5, 4 };
        }

        [TestCase(10, true)]
        [TestCase(2, false)]
        [TestCase(12, true)]
        [TestCase(17, true)]
        public void Test1(int target, bool canFind)
        {
            var checker = new TestCaseTwo(_list);

            var result = checker.Validate(target);

            result.Should().Be(canFind);
        }
    }
}