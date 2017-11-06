angular.module('Top8_Men_News').factory('MenNewFactory', function ($http, HostConstant) {
    var fac = {}
    fac.Get8MenNews = function () {
        return $http({
            url: `${HostConstant.hostUrl}/sanpham/get8newsmen`,
            method: 'GET'
        })
            .then(function (res) {
                return res;
            }).catch(function (err) {
                return err;
            });
    }
    fac.GetByID = function (id) {
        //return $http.get(`${HostConstant.hostUrl}/sanpham/${id}`)

    }
    return fac;
});