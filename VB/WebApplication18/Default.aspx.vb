Imports DevExpress.DashboardWeb.Native
Imports Storages
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Script.Serialization
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Xml.Linq

Namespace WebApplication18
    Partial Public Class [Default]
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        End Sub

        Protected Sub ASPxDashboard1_CustomDataCallback(ByVal sender As Object, ByVal e As DevExpress.Web.CustomDataCallbackEventArgs)
            Dim parameters As Dictionary(Of String, String) = (New JavaScriptSerializer()).Deserialize(Of Dictionary(Of String, String))(e.Parameter)
            If Not parameters.ContainsKey("ExtensionName") Then
                Return
            End If

            Dim newDashboardStorage As New CustomDashboardFileStorage("~/App_Data/Dashboards")
            If parameters("ExtensionName") = "dxdde-delete-dashboard" AndAlso parameters.ContainsKey("DashboardID") Then
                newDashboardStorage.DeleteDashboard(parameters("DashboardID"))
            End If
        End Sub
    End Class
End Namespace