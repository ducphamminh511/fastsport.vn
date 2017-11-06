angular.module('Top8_Men_News').config(configFunction);
configFunction.$inject = ['$routeProvider', '$locationProvider'];

configFunction.$inject = ['$routeProvider', '$locationProvider'];
function configFunction($routeProvider, $locationProvider) {
    //let urlParams = productMgmtConstant.appUrl.productMgmt.routeUrl + '/:route';

    $routeProvider
        .when('/Home/Detail/:id', {
            templateUrl: '/js/Template/ProductDetail.html',
            controller: 'ProductDetailController',
            //controllerAs: 'vm',
        });
    //$locationProvider.html5Mode(true);
};