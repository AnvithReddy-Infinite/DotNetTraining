using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOverloadingDemo
{
    internal class AgeException: ApplicationException
    {
        string message;
        public AgeException(int msg)
        {
            message = msg + "is invalid age.";
        }
        public override string ToString()
        {
            return message;
        }
    }
}
