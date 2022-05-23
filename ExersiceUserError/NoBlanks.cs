using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceUserError
{
    internal class NoBlanks : UserError
    {
        public override string UEMessage()
        {
            return ("Username cannot have blanks. ");
        }
    }
}
