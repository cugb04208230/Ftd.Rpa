using System;

namespace Ftd.Rpa.BaseModel.Identity
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// 最后登录初始化
        /// </summary>
        /// <param name="ip"></param>
        public void InitLogin(string ip = "")
        {
            LastLoginAt = DateTimeOffset.UtcNow;
            LastLoginIp = ip;
        }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTimeOffset? LastLoginAt { set; get; }

        /// <summary>
        /// 最后登录IP
        /// </summary>
        public string LastLoginIp { set; get; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { set; get; }

        /// <summary>
        /// 密码Hash
        /// </summary>
        public string PasswordHash { set; get; }
    }
}
