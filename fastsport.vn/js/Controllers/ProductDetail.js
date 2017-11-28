angular.module('Top8_Men_News')
    .controller('ProductDetailController', function ($scope, $http, $location, $route, HostConstant) {
        console.log($route);
        activate();
        var imgUrl = 'images/HinhSP/';
        var arrayImg = ['Hinh_1', 'Hinh_2', 'Hinh_3', 'Hinh_4', 'Hinh_5'];

        function activate() {
            $http.get(`${HostConstant.hostUrl}/sanpham/${$route.current.params.id}`)
                .then(function (result) {
                    formatImgUrl(arrayImg, result.data.data);
                    console.log(result.data.data);
                    $scope.productDetail = result.data.data;

                }).catch(function (err) {
                    console.log(err);
                });
        };

        function formatImgUrl(arrayQuery, Product) {
            for (let pro in Product) {
                arrayQuery.forEach(function (query) {
                    if (pro === query) {
                        Product[query] = imgUrl + Product[query];
                    }
                })
            }
        };
});