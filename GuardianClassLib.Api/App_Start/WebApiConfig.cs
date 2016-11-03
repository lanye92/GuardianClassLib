using GuardianClassLib.Api.Filter;
using GuardianClassLib.HELPER;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GuardianClassLib.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            //var urls= ConfigurationManager.AppSettings["CorsUrls"];
            var cors = new EnableCorsAttribute("*", "*", "*") {SupportsCredentials = true};
            config.EnableCors(cors);
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("DefaultApi", "{controller}/{id}", new { id = RouteParameter.Optional });
            //异常捕获
            config.Filters.Add(new ExceptionFilter());
            //Log4net配置
            Logger.SetConfig();
        }
    }
}
