﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EducationSystem
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RouteConfig.RegisterRoutes(RouteTable.Routes);

        }
        protected void Application_Error(object sender, EventArgs e)
        {
            //Exception exception = Server.GetLastError();
            //Response.Clear();

            //HttpException httpException = exception as HttpException;

            //if (httpException != null)
            //{
            //    string action;

            //    switch (httpException.GetHttpCode())
            //    {
            //        case 404:
            //            // page not found
            //            action = "404";
            //            break;
            //        case 500:
            //            // server error
            //            action = "500";
            //            break;
            //        default:
            //            action = "General";
            //            break;
            //    }
            //    // clear error on server
            //    Server.ClearError();
            //    Response.Redirect(String.Format("~/Error/{0}", action));
            //    //Response.Redirect(String.Format("~/Error/{0}/?message={1}", action, exception.Message));
            //}
        }

    }
}
