using System;

namespace Ftd.Rpa.BaseModel
{
    /// <summary>
    /// 基础实体
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// 新建实体初始化
        /// </summary>
        /// <param name="createdBy"></param>
        /// <param name="modifiedBy"></param>
        public void InitCreate(Guid? createdBy = null, Guid? modifiedBy = null)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTimeOffset.UtcNow;
            LastModifiedAt = DateTimeOffset.UtcNow;
            CreatedBy = createdBy;
            LastModifiedBy = modifiedBy;
        }

        /// <summary>
        /// 修改实体初始化
        /// </summary>
        /// <param name="modifiedBy"></param>
        public void InitModify(Guid? modifiedBy = null)
        {
            LastModifiedAt = DateTimeOffset.UtcNow;
            LastModifiedBy = modifiedBy;
        }

        /// <summary>
        /// 删除实体初始化
        /// </summary>
        /// <param name="deletedBy"></param>
        public void InitDelete(Guid? deletedBy = null)
        {
            DeletedAt = DateTimeOffset.UtcNow;
            DeletedBy = deletedBy;
        }

        /// <summary>
        /// 主键
        /// </summary>
        public Guid Id { set; get; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTimeOffset CreatedAt { set; get; }

        /// <summary>
        /// 创建者
        /// </summary>
        public Guid? CreatedBy { set; get; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTimeOffset? LastModifiedAt { set; get; }

        /// <summary>
        /// 最后修改者
        /// </summary>
        public Guid? LastModifiedBy { set; get; }

        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTimeOffset? DeletedAt { set; get; }

        /// <summary>
        /// 删除者
        /// </summary>
        public Guid? DeletedBy { set; get; }
    }
}
