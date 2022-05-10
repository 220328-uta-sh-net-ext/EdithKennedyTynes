using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopHouse_Test
{
    public class DummyForTest
    {
        public double Add(params double[] nums)// pararms keyword allows to pass any number of inputs as parameters
        {
            double result = 0;
            foreach (var n in nums)
            {
                result += n;
            }
            return result;
        }
    }
}
