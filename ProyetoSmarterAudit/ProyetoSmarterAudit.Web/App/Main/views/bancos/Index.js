(function() {
    angular.module('app').controller('app.views.banco.index', [
        '$scope', '$uibModal', 'abp.services.app.cuenta',
        function ($scope, $uibModal, cuentaService) {
            var vm = this;

            vm.bancos = [];

            function getList() {
                cuentaService.getListCuenta({}).then(function (result) {
                    vm.bancos = result.data.items;
                });
            }
            vm.openCuentaCreationModal = function () {
                var modalInstance = $uibModal.open({
                    templateUrl: '/App/Main/views/bancos/ModalView.cshtml',
                    controller: '',
                    controllerAs: 'vm',
                    backdrop: 'static'
                });

                modalInstance.result.then(function () {
                    getList();
                });
            };
            

            getList();
        }
    ]);
})();