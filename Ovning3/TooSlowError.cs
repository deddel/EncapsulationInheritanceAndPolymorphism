using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3 
{
    internal class TooSlowError: UserError
    {
        public override string UEMessage()
        {
            return "You are typing too slow. This fired an error!";
        }
    }
}
