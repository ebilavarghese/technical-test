namespace TechnicalTestCore
{
    using System.Collections.Generic;
    using System;
    internal class Minimum
    {
        public static int MinimumElementIn(List<int> intlist)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int minimum = intlist[0];
            for (var i=1; i<intlist.Count; i++) {
                if (intlist[i]<minimum) {
                    minimum = intlist[i];
                } 
            }
            return minimum;
        }
    }
}
