using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceUserError
{
    internal class RightLength : UserError
    {
        public override string UEMessage()
        {
            return ("This does not work. The username has to be atleast 3 characters");
        }
    }
}
