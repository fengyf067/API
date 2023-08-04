using System;

namespace 服务API.Model
{
    /// <summary>
    /// 用户实体类
    /// </summary>
    public class UsersModel
    {
        /// <summary>
        /// ID
        /// </summary>
        public int UsersId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int? Age { get; set; }

    }
}
