using System;

namespace Ftd.Rpa.HttpContext
{
    public interface ICurrentTrace
    {
        Guid TraceId { get; }
    }
}
