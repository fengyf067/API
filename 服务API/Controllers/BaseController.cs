using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace 服务API.Controllers
{
    /// <summary>
    /// 自定义路由 基类
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaseController : ControllerBase
    {



    }
}
