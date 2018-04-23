using DevExpress.DashboardWeb;
using Storages;
using System;

namespace AspDashboard_CustomExtension {
    public class Global : System.Web.HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            CustomDashboardFileStorage newDashboardStorage = new CustomDashboardFileStorage(@"~/App_Data/Dashboards");
            DashboardConfigurator.Default.SetDashboardStorage(newDashboardStorage);
        }
    }
}