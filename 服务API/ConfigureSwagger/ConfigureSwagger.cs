using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace 服务API.ConfigureSwagger
{
    public static class ConfigureSwagger
    {

        public static void AddSwaggerUp(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //注册Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("V1", new OpenApiInfo
                {
                    Title = "黑菠萝综合接口文档",
                    Version = "v1",
                    Description = $"服务API HTTP API V1",
                });
                c.OrderActionsBy(o => o.RelativePath);

                // 获取xml注释文件的目录
                var xmlPath = Path.Combine(AppContext.BaseDirectory, "服务API.xml");
                c.IncludeXmlComments(xmlPath, true);//默认的第二个参数是false，这个是controller的注释，记得修改
                // 获取xml注释文件的目录
                var xmlPathModel = Path.Combine(AppContext.BaseDirectory, "服务API.Model.xml");
                c.IncludeXmlComments(xmlPathModel, true);//默认的第二个参数是false，这个是controller的注释，记得修改
            });

            //添加cors 服务 配置跨域处理            
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("any", builder =>
            //    {
            //        builder.SetIsOriginAllowed(_ => true) //允许任何来源的主机访问
            //        .AllowAnyMethod()
            //        .AllowAnyHeader()
            //        .AllowCredentials();//指定处理cookie
            //    });
            //});
        }
    }
}
