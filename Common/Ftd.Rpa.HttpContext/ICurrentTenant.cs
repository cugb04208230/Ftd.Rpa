using Ftd.Rpa.BaseModel.Organization;
using System;

namespace Ftd.Rpa.HttpContext
{
    public interface ICurrentTenant
    {
        Guid TenantId { get; }
    }
}
