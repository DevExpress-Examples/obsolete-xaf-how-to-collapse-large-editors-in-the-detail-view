// Developer Express Code Central Example:
// How to collapse large editors in the detail view
// 
// Sometimes when your detail view contains a lot of editors, it is necessary to
// effectively use the space on the page. For example, usually editors in which
// collection properties are shown take a lot of space. You can reduce the space if
// you provide the capability to collapse large editors.
// In this example, I show
// how to put a large editor into the ASPxNavBar
// (ms-help://DevExpress.AspNet/clsDevExpressWebASPxNavBarASPxNavBartopic.htm)
// control that can expand/collapse its groups.
// 
// See Also:
// Access Editor
// Settings (ms-help://DevExpress.Xaf/CustomDocument2729.htm)
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1499

using System;
using System.Configuration;
using System.Web.Configuration;
using System.Web;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Web;

namespace WebSolution.Web {
    public class Global : System.Web.HttpApplication {
        public Global() {
            InitializeComponent();
        }
        protected void Application_Start(Object sender, EventArgs e) {
            WebApplication.OldStyleLayout = false;
        }
        protected void Session_Start(Object sender, EventArgs e) {
            WebApplication.SetInstance(Session, new WebSolutionAspNetApplication());
            if (ConfigurationManager.ConnectionStrings["ConnectionString"] != null) {
                WebApplication.Instance.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }
            DevExpress.ExpressApp.InMemoryDataStoreProvider.Register();
                        WebApplication.Instance.ConnectionString = DevExpress.ExpressApp.InMemoryDataStoreProvider.ConnectionString;
            WebApplication.Instance.Setup();
            WebApplication.Instance.Start();
        }
        protected void Application_BeginRequest(Object sender, EventArgs e) {
            string filePath = HttpContext.Current.Request.PhysicalPath;
            if (!string.IsNullOrEmpty(filePath)
                && (filePath.IndexOf("Images") >= 0) && !System.IO.File.Exists(filePath)) {
                HttpContext.Current.Response.End();
            }
        }
        protected void Application_EndRequest(Object sender, EventArgs e) {
        }
        protected void Application_AuthenticateRequest(Object sender, EventArgs e) {
        }
        protected void Application_Error(Object sender, EventArgs e) {
            ErrorHandling.Instance.ProcessApplicationError();
        }
        protected void Session_End(Object sender, EventArgs e) {
            WebApplication.DisposeInstance(Session);
        }
        protected void Application_End(Object sender, EventArgs e) {
        }
        #region Web Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
        }
        #endregion
    }
}
