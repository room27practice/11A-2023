using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors
{
    public class PartyException : ApplicationException
    {       
        public PartyException(string message) : base(message)
        { }
    }
}
