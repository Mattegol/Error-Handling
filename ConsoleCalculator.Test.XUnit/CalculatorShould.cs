using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace ConsoleCalculator.Test.XUnit
{
    public class CalculatorShould
    {

        [Fact]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();

            Assert.Throws<CalculationOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));

            Assert.ThrowsAny<CalculationException>(
                () => sut.Calculate(1, 1, "+"));

            var ex = Assert.Throws<CalculationOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));

            Assert.Equal("+", ex.Operation);
        }
        
    }
}
