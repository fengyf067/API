using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using 服务API.ConfigureSwagger;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace 服务API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // 配置依赖注入以在运行时根据依赖关系创建对象
        public void ConfigureServices(IServiceCollection services)
        {
            //注册swagger服务
            services.AddSwaggerUp();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // 配置中间件（middleware）以构建请求处理流水线。
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }
            //添加swagger相关的中间件
            app.UseSwagger();
            //配置Cors
            app.UseCors("any");
            
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/V1/swagger.json", "服务API V1");
                //路径配置，设置为空 表示直接在根域名（localhost:5000）访问 swagger-ui
                //注意 localhost:8088/swagger 是访问补发哦的，去launcnSetting.json 把 launchUrl 去掉
                //如果你想换一个路径 直接写名字即可，比如 c.RoutePrefix = "doc";
                c.RoutePrefix = "";//添加一层路径
            });
            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
