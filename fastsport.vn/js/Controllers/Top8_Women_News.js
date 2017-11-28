angular.module('Top8_Women_News').controller('WomenNewsController', function ($scope, $http, WomenNewFactory) {
    $scope.resultss = [];
    $scope.hasResultt = false;
    $scope.cart = [];

    $scope.GetProductwomen = function () {
        WomenNewFactory.Get8WomenNews().then(function (response) {
            var res = response.data;
            $scope.results = res.data;
            $scope.hasResult = res.result;
        });
    };
    $scope.GetProductwomen();
});