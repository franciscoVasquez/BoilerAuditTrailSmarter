﻿var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('ProyetoSmarterAudit');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);