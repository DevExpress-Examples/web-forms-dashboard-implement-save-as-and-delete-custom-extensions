Imports DevExpress.DashboardWeb
Imports Storages
Imports System

Namespace AspDashboard_CustomExtension
	Public Class [Global]
		Inherits System.Web.HttpApplication

		Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
			Dim newDashboardStorage As New CustomDashboardFileStorage("~/App_Data/Dashboards")
			DashboardConfigurator.Default.SetDashboardStorage(newDashboardStorage)
		End Sub
	End Class
End Namespace