namespace TechnicalTestCore
{
    using System;
    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt) {
            int sum = 0;
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            for (var i=1; i<=maxNrAsInt; i++) {
                sum = sum + i;
            }
            return sum;
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            long numInInteger=long.Parse(maxNrAsString);
            long sum=0;
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            for (var i=1; i <=numInInteger; i++)
            {
                sum =sum+i;
            }
            return sum.ToString();
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            
        }
    }
}
