function DeleteDashboardExtension(_designerWrapper) {
    var _this = this;
    this._designerWrapper = _designerWrapper;
    this._designer = _designerWrapper.getDesigner();
    this.name = "dxdde-delete-dashboard";
    this.deleteDashboard = function () {
        var dashboardid = _this._designer.dashboardContainer().id;
        var param = JSON.stringify({ DashboardID: dashboardid, ExtensionName: _this.name });
        _this._designer.menuVisible(false);
        _this._designerWrapper.PerformDataCallback(param, function () {
            _this._designer.close();
        });
    }
    this._menuItem = {
        id: this.name,
        title: "Delete",
        click: this.deleteDashboard,
        selected: ko.observable(false),
        disabled: ko.computed(function () { return !_this._designer.dashboard(); }),
        index: 113,
        hasSeparator: true
    };
}
DeleteDashboardExtension.prototype.start = function () {
    this._designer.menuItems.push(this._menuItem);
};
DeleteDashboardExtension.prototype.stop = function () {
    this._designer.menuItems.remove(this._menuItem);
};
