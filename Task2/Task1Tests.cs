using System.Collections;
using System.Collections.Generic;
using App.Task1;
using FluentAssertions;
using NUnit.Framework;

namespace Task2
{
    public class Task1Tests
    {
        private OutputFormatter _formatter;
        private IReferenceManager _referenceManager;

        [SetUp]
        public void Setup()
        {
            var officerBuilder = new OfficerBuilder();
            var stringParser = new Parser(officerBuilder);
            _referenceManager = new ReferenceManager(stringParser);
            _formatter = new OutputFormatter();
        }

        [TestCaseSource(typeof(ReferencePathCases))]
        public void Test1(string input, List<int> estimatedResult)
        {
            var result = _referenceManager.FindPath(input);
            _formatter.Print(result);
            result.Should().BeEquivalentTo(estimatedResult);
        }

        private class ReferencePathCases : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { "{{1, [2]}, {2,[3,4]}}", new List<int> { 3, 4, 2, 1 } };
                yield return new object[] { "{1,[2]}, {3,[4]}", new List<int> { 2, 1, 4, 3 } };
                yield return new object[] { "{{1, [2] }, {2, [3, 4] }, {3, [ 5, 7] } }", new List<int> { 4, 5, 7, 3, 2, 1 } };
                yield return new object[] { "{{3, [2,4] },{5, [3] } }", new List<int> { 2, 4, 3, 5 } };
                yield return new object[] { "{{5, [3] }, {3, [2,4] }}", new List<int> { 2, 4, 3, 5 } };
                yield return new object[] { "{{ 2, [ 3, 4] }, { 1, [2] } }", new List<int> { 3, 4, 2, 1 } };
                yield return new object[] { "{{ 2,[ 3, 4] }, { 1,[2] }, { 3, [ 5, 4] } }", new List<int> { 4, 5, 3, 2, 1 } };
            }
        }
    }
}