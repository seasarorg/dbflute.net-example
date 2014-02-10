using System;
using DfExampleBiz.Common;

namespace DfExampleWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //log4net初期化
            log4net.Config.XmlConfigurator.Configure();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //アクセスコンテキストを設定してくれる
            WebAccessContext.SetAccessContext();
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            //リクエストが終わったら必ずクリア
            WebAccessContext.ClearAccessContext();
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}