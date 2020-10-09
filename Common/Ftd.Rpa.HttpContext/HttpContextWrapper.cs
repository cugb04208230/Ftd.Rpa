using Ftd.Rpa.BaseModel.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;

namespace Ftd.Rpa.HttpContext
{
    public class HttpContextWrapper : ICurrentTrace, ICurrentTenant, ICurrentResourceGroup, ICurrentUser
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private IHeaderDictionary _headers;

        private IHeaderDictionary Headers
        {
            get
            {
                if (_headers == null)
                {
                    _headers = _httpContextAccessor.HttpContext?.Request.Headers;
                }
                return _headers;
            }
        }

        public HttpContextWrapper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid TraceId => GetHeaderValues(ContextKeys.TraceId);

        public Guid TenantId => GetHeaderValues(ContextKeys.TenantId);

        public Guid ResourceGroupId => GetHeaderValues(ContextKeys.ResourceGroupId);

        public User User => throw new NotImplementedException();

        private Guid GetHeaderValues(string headerKey)
        {
            if (
                Headers != null &&
                Headers.TryGetValue(headerKey, out var value) &&
                value != StringValues.Empty &&
                Guid.TryParse(value.ToString(), out Guid result))
            {
                return result;
            }
            else
            {
                return Guid.Empty;
            }
        }
    }
}
