using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebApplicationEntitySwaggerSample01
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private const string LOCALIP = "";
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
          //var deger=  HttpContext.Current.Request.UserHostAddress;
          //  var request = ((System.Web.HttpApplication)sender).Request;

          //  string ip1 = request.UserHostAddress;
          //  string shortLocalIP;
          //  if (ip1 != null && ip1.Contains("."))
          //  {
          //      string[] ipValues = ip1.Split('.');
          //      shortLocalIP = ipValues[0] + "." + ipValues[1];
          //  }
          //  else
          //  {
          //      shortLocalIP = "192.168";
          //  }

          //  //var ip2 = request.ServerVariables["LOCAL_ADDR"];
          //  //var ip3 = request.ServerVariables["SERVER_ADDR"];

          //  if (shortLocalIP != LOCALIP)
          //  {
          //      if ("/Login/User".Equals(request.RawUrl, StringComparison.InvariantCultureIgnoreCase))
          //      {
          //          return;
          //      }

          //      Response.Clear();
          //      Response.Redirect("/Login/User");
          //      Response.End();
          //  }

            Logger logger = LogManager.GetLogger("databaseLogger");
            logger.ErrorException("asdasdasdasd", new NotImplementedException());

            logger.WarnException("warn exception", new NotImplementedException());
        }
    }
}
