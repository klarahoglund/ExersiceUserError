using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersiceUserError
{
    internal class NotEmpty : UserError
    {
        public override string UEMessage()
        {
            return ("This does not work. The username cannot be empty");
        }
    }
}
