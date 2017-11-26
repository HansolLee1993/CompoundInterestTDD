using System;


namespace CompoundInterestLib
{
    /**
     * 
     * A = P (1 + r/n) (nt)
     * A = the future value of the investment/loan, including interest
     * P = the principal investment amount (the initial deposit or loan amount)
     * r = the annual interest rate (decimal)
     * n = the number of times that interest is compounded per year
     * t = the number of years the money is invested or borrowed for
     * Total compounded interest = P (1 + r/n) (nt) - P
     */
    public class CompoundInterest
    {
        public double getAmount(double P, double r, double n, double t)
        {
          
            if (P < 0)
            {
                throw new Exception("The principal cannot be negative number.");
            }

            if (n < 0)
            {
                throw new Exception("The number of times cannot be negative number.");
            }

            if (n == 0)
            {
                throw new Exception("The number of times cannot divide by 0 time.");
            }

            if (t < 0)
            {
                throw new Exception("The number of year cannot be negative number.");
            }

            return (P * Math.Pow(1+(r / n), n * t));
        }
    }
}
