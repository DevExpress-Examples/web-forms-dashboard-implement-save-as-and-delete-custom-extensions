<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication18.Default" %>

<%@ Register Assembly="DevExpress.Dashboard.v16.2.Web, Version=16.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <script type="text/javascript" src="Scripts/SaveAsExtension.js"></script>
    <script type="text/javascript" src="Scripts/DeleteExtension.js"></script>

    <script type="text/html" id="dx-dshd-form-save-as">
        <!-- ko with: findExtension("dxdde-save-as") -->
        <div data-bind="dxTextBox: { value: newName }"></div>
        <div data-bind="dxButton: { text: 'Save as', onClick: saveAs }"></div>
        <!-- /ko -->
    </script>

    <script type="text/javascript">
        function onInit(sender, args) {
            var wdc = sender.getDesigner();
            wdc.registerExtension(new SaveAsDashboardExtension(sender));
            wdc.registerExtension(new DeleteDashboardExtension(sender));
        }
    </script>

    <form id="form1" runat="server">
        <div>
            <dx:ASPxDashboard ID="ASPxDashboard1" ClientInstanceName="dashboard" runat="server" UseDashboardConfigurator="true" OnCustomDataCallback="ASPxDashboard1_CustomDataCallback">
                <ClientSideEvents Init="onInit" />
            </dx:ASPxDashboard>
        </div>
    </form>
</body>
</html>
