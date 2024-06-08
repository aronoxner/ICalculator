using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator
{
    class MultPeriodsExceptions : Exception
    {
        public override string Message
        {
            get { return "Input a valid number with only 1 period."; }
        }
    }
}
