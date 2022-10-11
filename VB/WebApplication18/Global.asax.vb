Imports DevExpress.DashboardWeb
Imports Storages
Imports System
Imports System.Web

Namespace WebApplication18

    Public Class [Global]
        Inherits HttpApplication

        Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
            Dim newDashboardStorage As CustomDashboardFileStorage = New CustomDashboardFileStorage("~/App_Data/Dashboards")
            DashboardConfigurator.Default.SetDashboardStorage(newDashboardStorage)
        End Sub
    End Class
End Namespace
