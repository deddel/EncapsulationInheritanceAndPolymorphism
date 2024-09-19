using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class AttitudeError: UserError
    {
        public override string UEMessage()
        {
            return "You have an attitude! This fired an error";
        }
    }
}
