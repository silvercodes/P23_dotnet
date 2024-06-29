using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDriver.Exceptions
{
    internal class ConnectionException : DbDriverException
    {
        public ConnectionException(string? message) : base(message)
        {
        }
    }
}
