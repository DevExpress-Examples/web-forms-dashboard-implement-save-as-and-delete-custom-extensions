<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="AspDashboard_CustomExtension.Default" %>

<%@ Register Assembly="DevExpress.Dashboard.v18.2.Web.WebForms, Version=18.2.16.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <script type="text/javascript" src="Scripts/SaveAsExtension.js"></script>
    <script type="text/javascript" src="Scripts/DeleteExtension.js"></script>

    <!-- Defines the "Save As" extension template. -->
    <script type="text/html" id="dx-save-as-form">
        <div>Dashboard Name:</div>
        <div style="margin: 10px 0" data-bind="dxTextBox: { value: newName }"></div>
        <div data-bind="dxButton: { text: 'Save', onClick: saveAs }"></div>
    </script>

    <script type="text/javascript">
        function onBeforeRender(sender) {
            var control = sender.GetDashboardControl();
            control.registerExtension(new SaveAsDashboardExtension(control));
            control.registerExtension(new DeleteDashboardExtension(sender));
        }
    </script>

    <form id="form1" runat="server">
        <div style="position: absolute; top: 0; bottom: 0; left: 0; right: 0;">
            <dx:ASPxDashboard ID="ASPxDashboard1" ClientInstanceName="dashboard" runat="server" 
                UseDashboardConfigurator="true" 
                OnCustomDataCallback="ASPxDashboard1_CustomDataCallback" 
                WorkingMode="Designer"
                Width="100%" Height="100%">
                <ClientSideEvents BeforeRender="onBeforeRender" />
            </dx:ASPxDashboard>
        </div>
    </form>
</body>
</html>