﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Music_Store.Service
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
