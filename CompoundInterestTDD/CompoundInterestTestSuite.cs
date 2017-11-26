using CompoundInterestLib;
using System;
using Xunit;

namespace CompoundInterestTDD
{
    public class CompoundInterestTestSuite
    {

        // 1) Principal 0 amount 0
        [Fact]
        public void GivenPrincipal10ExpectAbount10()
        {
            double P = 0.0;
            CompoundInterest ci = new CompoundInterest();
            double actual = ci.getAmount(P, 1, 1, 1);
            double expected = 0;
            Assert.Equal(expected, actual);
        }

        // 2) negative time throw exception
        [Fact]
        public void GivenNegativeNThrowException()
        {
            double n = -1.0;
            CompoundInterest ci = new CompoundInterest();
            Exception ex = Assert.Throws<Exception>(
                () => ci.getAmount(1, 1, n, 1)
            );
            string actual = ex.Message;
            string expected = "The number of times cannot be negative number.";
            Assert.Equal(expected, actual);
        }

        // 3) divide by zero exception when n=0
        [Fact]
        public void GivenDivideNBy0ThrowException()
        {
            double n = 0.0;
            CompoundInterest ci = new CompoundInterest();
            Exception ex = Assert.Throws<Exception>(
                () => ci.getAmount(1, 1, n, 1)
            );
            string actual = ex.Message;
            string expected = "The number of times cannot divide by 0 time.";
            Assert.Equal(expected, actual);
        }

        // 4) negative n throw exception
        [Fact]
        public void GivenNagativeYearThrowException()
        {
            double t = -1.0;
            CompoundInterest ci = new CompoundInterest();
            Exception ex = Assert.Throws<Exception>(
                () => ci.getAmount(1, 1, 1, t)
            );
            string actual = ex.Message;
            string expected = "The number of year cannot be negative number.";
            Assert.Equal(expected, actual);
        }

        // 5) P = 5000. r = 5/100 = 0.05 (decimal). n = 12. t = 10 
        // A = 5000(1+0.05/12) ^ (12(10)) = 8235.0
        [Fact]
        public void GivenParametersExpectAmount()
        {
            double P = 5000;
            double r = 0.05;
            double n = 12.0;
            double t = 10.0;
            CompoundInterest ci = new CompoundInterest();
            double actual = Math.Round(ci.getAmount(P, r, n, t), 1);// round to 2 decimal places
            double expected = 8235.0;
            Assert.Equal(expected, actual);
        }

        // 6)negative principal throw exception
        [Fact]
        public void GivenNegativePrincipalThrowException()
        {
            double P = -1.0;
            CompoundInterest ci = new CompoundInterest();
            Exception ex = Assert.Throws<Exception>(
                () => ci.getAmount(P, 1, 1, 1)
            );
            string actual = ex.Message;
            string expected = "The principal cannot be negative number.";
            Assert.Equal(expected, actual);
        }
    }
}
