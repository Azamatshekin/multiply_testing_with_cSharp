using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MultiplyWithTest
    {
        public double multiply(double a, double b)
        {
            return a * b;
        }
        public void multiplyTest()
        {
            // arrange


            System.Diagnostics.Trace.Assert(multiply(-3, 3) == -9, "multiply -3*3 worked incorrectly");
            System.Diagnostics.Trace.Assert(multiply(0, 3) == 0, "multiply 0*3 worked incorrectly");
            System.Diagnostics.Trace.Assert(multiply(-3, 5) == -15, "multiply -3*5 worked incorrectly");

            System.Diagnostics.Debug.Assert(multiply(3, 3) == 9, "multiply 3*3 worked incorrectly");
            System.Diagnostics.Debug.Assert(multiply(0, 2) == 0, "multiply 0*2 worked incorrectly");
            System.Diagnostics.Debug.Assert(multiply(3.9, 2) == 7.8, "multiply 3.9*2 worked incorrectly");
            System.Diagnostics.Debug.Assert(multiply(-3, -3) == 9, "multiply -3*-3 worked incorrectly");
            System.Diagnostics.Debug.Assert(multiply(-3, 3) == -9, "multiply -3*3 worked incorrectly");
        }
    }
}
