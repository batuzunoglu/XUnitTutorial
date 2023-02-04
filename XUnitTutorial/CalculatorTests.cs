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
    }
}
