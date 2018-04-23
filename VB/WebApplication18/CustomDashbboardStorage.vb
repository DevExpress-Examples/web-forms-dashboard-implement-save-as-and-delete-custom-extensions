Imports DevExpress.DashboardWeb
Imports System.IO

Namespace Storages

    Public Class CustomDashboardFileStorage
        Inherits DashboardFileStorage

        Public Sub New(ByVal workingDirectory As String)
            MyBase.New(workingDirectory)
        End Sub

        Public Sub DeleteDashboard(ByVal dashboardID As String)
            Dim dashboardPath = MyBase.ResolveFileName(dashboardID)
            If File.Exists(dashboardPath) Then
                File.Delete(dashboardPath)
            End If
        End Sub
    End Class
End Namespace