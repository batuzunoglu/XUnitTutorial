using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTutorial
{
    public class CalculatorTests
    {
        private readonly Calculator _sut; // System under test

        public CalculatorTests()
        {
            _sut = new Calculator();
        }

        [Fact]
        public void AddTwoNumbersShouldEqualTheirEqual()
        {
            _sut.Add(5);
            _sut.Add(6);
            Assert.Equal(11, _sut.Value);
        }

        [Theory]
        [InlineData(5,2,3)]
        [InlineData(0,0,0)]
        [InlineData(-2,-1,-1)]
        public void AddTwoNumbersShouldEqualTheirEqualTheory(
            decimal expected, decimal firstToAdd, decimal secondToAdd)
        {
            _sut.Add(firstToAdd);
            _sut.Add(secondToAdd);
            Assert.Equal(expected, _sut.Value);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void AddManyNumbersShouldEqualTheirEqualTheory(
    decimal expected, params decimal[] valuesToAdd)
        {
            foreach (var value in valuesToAdd)
            {
                _sut.Add(value);
            }
            Assert.Equal(expected, _sut.Value);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { 15, new decimal[] { 10, 5 } };
            yield return new object[] { 15, new decimal[] { 1, 5, 9 } };
            yield return new object[] { -5, new decimal[] { -10, 5 } };
            yield return new object[] { 0, new decimal[] { -1, 1} };
            yield return new object[] { 0, new decimal[] { 0, 0} };
        }
    }
}
