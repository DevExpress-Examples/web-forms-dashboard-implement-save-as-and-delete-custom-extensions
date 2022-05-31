<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580451/20.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T466761)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for Web Forms - How to Create Custom Extesions to add the Save As and Delete Commands

This example demonstrates how to add the "Save As" and "Delete" [menu items](https://docs.devexpress.com/Dashboard/117444) to the Web Dashboard's UI by implementing the corresponding [custom extensions](https://docs.devexpress.com/Dashboard/117543):

* The **Save As** menu item allows end-users to save the current dashboard with a new name.
* The **Delete** menu item deletes the opened dashboard from the [dashboard storage](https://docs.devexpress.com/Dashboard/116299).

The image below shows the result of the extensions implementation.

![](readme.png)

## Files to look At

* [CustomDashboardStorage.cs](./CS/AspDashboard_CustomExtension/CustomDashboardStorage.cs) (VB: [CustomDashboardStorage.vb](./VB/AspDashboard_CustomExtension/CustomDashboardStorage.vb))
* [Default.aspx](./CS/AspDashboard_CustomExtension/Default.aspx) (VB: [Default.aspx.vb](./VB/AspDashboard_CustomExtension/Default.aspx.vb))
* [Default.aspx.cs](./CS/AspDashboard_CustomExtension/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/AspDashboard_CustomExtension/Default.aspx.vb))
* [DeleteExtension.js](./CS/AspDashboard_CustomExtension/Scripts/DeleteExtension.js) (VB: [DeleteExtension.js](./VB/AspDashboard_CustomExtension/Scripts/DeleteExtension.js))
* [SaveAsExtension.js](./CS/AspDashboard_CustomExtension/Scripts/SaveAsExtension.js) (VB: [SaveAsExtension.js](./VB/AspDashboard_CustomExtension/Scripts/SaveAsExtension.js))


## Documentation

- [Extensions Overview](https://docs.devexpress.com/Dashboard/117543/web-dashboard/ui-elements-and-customization/extensions-overview)
- [Dashboard Menu](https://docs.devexpress.com/Dashboard/117444/web-dashboard/ui-elements-and-customization/ui-elements/dashboard-menu)
- [Prepare Dashboard Storage](https://docs.devexpress.com/Dashboard/116299/web-dashboard/aspnet-web-forms-dashboard-control/prepare-dashboard-storage)

## More Examples

- [Dashboard for MVC - How to implement the Save As and Delete functionality by creating custom extensions](https://github.com/DevExpress-Examples/mvc-dashboard-how-to-define-extensions-providing-the-save-as-and-delete-functionality-t504201)
- [Dashboard for ASP.NET Core - How to implement the Save As and Delete functionality by creating custom extensions](https://github.com/DevExpress-Examples/aspnet-core-dashboard-how-to-implement-the-save-as-and-delete-functionality-by-creating-cu-t601084)
- [Dashboard for JavaScript - How to implement Save As and Delete functionality by creating custom extensions](https://github.com/DevExpress-Examples/DashboardCoreAngularSaveAsExtension)
