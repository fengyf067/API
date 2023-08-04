using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using 服务API.Model;

namespace 服务API.Controllers
{
    /// <summary>
    /// 用户控制接口
    /// </summary>
    public class UserController : BaseController
    {
        /// <summary>
        /// 测试Hello Word
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PostUsersTestSwagger(UsersModel usersModel)
        {
            return Ok("Hello world");
        }
        /// <summary>
        /// 测试Hello Word
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public UsersModel UsersTestSwagger(string vers)
        {
            return new UsersModel();
        }
        /// <summary>
        /// 测试Hello Word
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult UsersTestSwagger(UsersModel usersModel)
        {
            return Ok("Hello world");
        }
        
    }

    /// <summary>
    /// 数据库访问
    /// </summary>
    public class OracleController : BaseController
    {
        /// <summary>
        /// 测试Hello Word
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult UsersTestSwagger(UsersModel usersModel)
        {
            return Ok("Hello world");
        }
    }
}
