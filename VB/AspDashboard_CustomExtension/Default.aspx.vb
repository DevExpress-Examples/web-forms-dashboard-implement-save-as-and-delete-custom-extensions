Imports Storages
Imports System
Imports System.Collections.Generic
Imports System.Web.Script.Serialization

Namespace AspDashboard_CustomExtension

    Public Partial Class [Default]
        Inherits Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub ASPxDashboard1_CustomDataCallback(ByVal sender As Object, ByVal e As DevExpress.Web.CustomDataCallbackEventArgs)
            Dim parameters As Dictionary(Of String, String) = New JavaScriptSerializer().Deserialize(Of Dictionary(Of String, String))(e.Parameter)
            If Not parameters.ContainsKey("ExtensionName") Then Return
            Dim newDashboardStorage As CustomDashboardFileStorage = New CustomDashboardFileStorage("~/App_Data/Dashboards")
            If Equals(parameters("ExtensionName"), "dxdde-delete-dashboard") AndAlso parameters.ContainsKey("DashboardID") Then newDashboardStorage.DeleteDashboard(parameters("DashboardID"))
        End Sub
    End Class
End Namespace
