using System;

namespace Ftd.Rpa.BaseModel.Organization
{
    /// <summary>
    /// 租户
    /// </summary>
    public class Tenant : BaseEntity
    {
        /// <summary>
        /// 父一级租户Id
        /// </summary>
        public Guid? ParentTenantId { set; get; }

        /// <summary>
        /// 租户名称
        /// </summary>
        public string Name { set; get; }

    }
}
