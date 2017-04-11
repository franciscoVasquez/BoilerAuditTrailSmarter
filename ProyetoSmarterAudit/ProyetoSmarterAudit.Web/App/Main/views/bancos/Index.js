(function () {
    angular.module('app').controller('app.views.banco.index', [
        '$scope', 'abp.services.app.cuenta',
        function ($scope, cuentaService) {
            var vm = this;

            vm.bancos = [];

            function getList() {
                cuentaService.getListCuenta({}).then(function (result) {
                    vm.bancos = result.data.items;
                });
            }

            

            getList();
        }
    ]);
})();