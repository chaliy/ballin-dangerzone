﻿using System.Web.Http;
using System.Web.Optimization;
using System.Web.Routing;
using UnderscoreBundler;

namespace WebApp
{
    public class App : System.Web.HttpApplication
    {        
        protected void Application_Start()
        {
            RouteTable.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { action = RouteParameter.Optional }
            );


            // Because of changes in boundling support
            // I cannot now combine both templates and scripts
            // This will be resolved in next versions of the bundler
            var homeTemplates = new Bundle("~/client/hometemplates")
                .IncludeDirectory("~/client/home/", "*.html");
            //homeTemplates.Transforms.Add(new JsMinify());
            homeTemplates.Builder = new CompiledUndrescoreTemplatesBundler();
            BundleTable.Bundles.Add(homeTemplates);

            var homeJs = new Bundle("~/client/homejs")
                .Include("~/client/base.js")
                .Include("~/client/home/home.js")
                .Include("~/client/home/app.js");
            //homeJs.Transforms.Add(new JsMinify());
            BundleTable.Bundles.Add(homeJs);
        }
    }
}