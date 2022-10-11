Imports DevExpress.DashboardWeb
Imports System.IO

Namespace Storages

    Public Class CustomDashboardFileStorage
        Inherits DashboardFileStorage

        Public Sub New(ByVal workingDirectory As String)
            MyBase.New(workingDirectory)
        End Sub

        Public Sub DeleteDashboard(ByVal dashboardID As String)
            Dim dashboardPath = ResolveFileName(dashboardID)
            If File.Exists(dashboardPath) Then File.Delete(dashboardPath)
        End Sub
    End Class
End Namespace
