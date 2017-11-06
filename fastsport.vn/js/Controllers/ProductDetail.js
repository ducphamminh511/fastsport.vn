angular.module('Top8_Men_News')
    .controller('ProductDetailController', function ($scope, $http, $location, $route, HostConstant) {
        console.log($route);
        activate();

        function activate() {
            $http.get(`${HostConstant.hostUrl}/sanpham/${$route.current.params.id}`)
                .then(function (result) {
                    $scope.productDetail = result.data.data;
                }).catch(function (err) {
                    console.log(err);
                });
        };
});