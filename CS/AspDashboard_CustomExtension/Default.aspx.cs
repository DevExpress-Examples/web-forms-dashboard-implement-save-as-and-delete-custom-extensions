using Storages;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace AspDashboard_CustomExtension {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ASPxDashboard1_CustomDataCallback(object sender, DevExpress.Web.CustomDataCallbackEventArgs e) {
            Dictionary<string, string> parameters = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(e.Parameter);
            if (!parameters.ContainsKey("ExtensionName"))
                return;

            CustomDashboardFileStorage newDashboardStorage = new CustomDashboardFileStorage(@"~/App_Data/Dashboards");
            if (parameters["ExtensionName"] == "dxdde-delete-dashboard" && parameters.ContainsKey("DashboardID"))
                newDashboardStorage.DeleteDashboard(parameters["DashboardID"]);
        }
    }
}