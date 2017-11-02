app.controller('MenNewController', function ($scope, $http, MenNewFactory) {
    $scope.results = [];

    $scope.GetProduct = function () {
        MenNewFactory.Get8MenNews().then(function (response) {
            var res = response.data;
            for (let i = 0; i <= res.data.length; i++) {
                (function (i) {
                    var result = {};
                    result.ID = res.data[i].ID;
                    result.Code = res.data[i].Code;
                    result.Name = res.data[i].Name;
                    result.Gia = res.data[i].Gia;
                    result.Sale_off = res.data[i].Sale_off;
                    result.color_id = res.data[i].color_id;
                    result.trang_thai_sp_id = res.data[i].trang_thai_sp_id;
                    result.loai_sp_id = res.data[i].loai_sp_id;
                    result.size_id = res.data[i].size_id;
                    result.nhom_sp_id = res.data[i].nhom_sp_id;
                    result.Hinh_1 = res.data[i].Hinh_1;
                    result.Hinh_2 = res.data[i].Hinh_2;
                    result.Hinh_3 = res.data[i].Hinh_3;
                    result.Hinh_4 = res.data[i].Hinh_4;
                    result.Hinh_5 = res.data[i].Hinh_5;
                    result.Hinh_6 = res.data[i].Hinh_6;
                    result.Hinh_7 = res.data[i].Hinh_7;
                    result.Hinh_8 = res.data[i].Hinh_8;
                    result.Hinh_9 = res.data[i].Hinh_9;
                    result.Hinh_10 = res.data[i].Hinh_10;
                    $scope.results.push(result);
                })(i);
            };
        });
    };
    $scope.GetProductByID = function (id) {
        MenNewFactory.GetByID(id).then(function (response) {
            var res = response.data;
            for (let i = 0; i <= res.data.length; i++) {
                (function (i) {
                    var result = {};
                    result.ID = res.data[i].ID;
                    result.Code = res.data[i].Code;
                    result.Name = res.data[i].Name;
                    result.Gia = res.data[i].Gia;
                    result.Sale_off = res.data[i].Sale_off;
                    result.color_id = res.data[i].color_id;
                    result.trang_thai_sp_id = res.data[i].trang_thai_sp_id;
                    result.loai_sp_id = res.data[i].loai_sp_id;
                    result.size_id = res.data[i].size_id;
                    result.nhom_sp_id = res.data[i].nhom_sp_id;
                    result.Hinh_1 = res.data[i].Hinh_1;
                    result.Hinh_2 = res.data[i].Hinh_2;
                    result.Hinh_3 = res.data[i].Hinh_3;
                    result.Hinh_4 = res.data[i].Hinh_4;
                    result.Hinh_5 = res.data[i].Hinh_5;
                    result.Hinh_6 = res.data[i].Hinh_6;
                    result.Hinh_7 = res.data[i].Hinh_7;
                    result.Hinh_8 = res.data[i].Hinh_8;
                    result.Hinh_9 = res.data[i].Hinh_9;
                    result.Hinh_10 = res.data[i].Hinh_10;
                    $scope.results.push(result);
                })(i);
            };
        });
    };

   
});