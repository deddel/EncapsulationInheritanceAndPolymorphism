using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class NumberTooLargeError: UserError
    {
        public override string UEMessage()
        {
            return "You have entered a number which is too large. This fired an error!";
        }
    }
}
