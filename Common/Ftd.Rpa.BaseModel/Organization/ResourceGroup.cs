using System;

namespace Ftd.Rpa.BaseModel.Organization
{
    /// <summary>
    /// 资源组
    /// </summary>
    public class ResourceGroup : BaseEntity
    {
        /// <summary>
        /// 父一级资源组Id
        /// </summary>
        public Guid? ParentResourceGroupId { set; get; }

        /// <summary>
        /// 资源组名称
        /// </summary>
        public string Name { set; get; }
    }
}
