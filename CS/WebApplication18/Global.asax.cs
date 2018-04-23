using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using Storages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication18 {
    public class Global : System.Web.HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            CustomDashboardFileStorage newDashboardStorage = new CustomDashboardFileStorage(@"~/App_Data/Dashboards");
            DashboardConfigurator.Default.SetDashboardStorage(newDashboardStorage);
        }
    }
}