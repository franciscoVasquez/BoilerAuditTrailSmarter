(function () {
    angular.module('app').controller('app.views.banco.ModalView', [
        '$scope', 'abp.services.app.cuenta',
            function ($scope, cuentaService) {
                var vm = this;

                vm.save = function () {
                    cuentaService.createCuenta(vm.bancos)
                        .then(function () {
                            abp.notify.info(App.localize('Guardado Satisfactoriamente'));
                            //$uibModalInstance.close();
                        });
                };
                vm.cancel = function () {
                    //$uibModalInstance.dismiss({});
                };
            }


        ]);

})();