using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace North.Identity.Core.Exceptions;

public abstract class DomainException : Exception
{
    public virtual string Code { get; }

    protected DomainException(string message) : base(message)
    {
    }
}
