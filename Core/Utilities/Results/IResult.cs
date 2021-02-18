using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // For methods that with return type : void
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
