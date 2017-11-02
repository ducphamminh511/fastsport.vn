app.factory('MenNewFactory', function ($http) {
    var fac = {}
    fac.Get8MenNews = function () {
        return $http.get('http://localhost:63263/sanpham/get8newsmen');
    }
    fac.GetByID = function (id) {
        return $http.get('http://localhost:63263/sanpham/'+id)
    }
    return fac;
});