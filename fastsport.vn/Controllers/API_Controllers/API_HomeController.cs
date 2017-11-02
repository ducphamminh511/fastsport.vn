using fastsport.vn.Models;
using fastsport.vn.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace fastsport.vn.Controllers
{
    [RoutePrefix("sanpham")]
    public class API_HomeController : ApiController
    {
        FastSportEntities db = new FastSportEntities();
        [Route("")]
        public API_Results GetAll()
        {
            List<sanphamvm> lst_sanpham = db.san_pham.Select(x => new sanphamvm
            {
                ID = x.ID,
                Code = x.Code,
                Name = x.Name,
                Gia = (float)x.Gia,
                Sale_off = (float)x.Sale_off,
                color_id = (int)x.color_id,
                trang_thai_sp_id = (int)x.trang_thai_sp_id,
                loai_sp_id = (int)x.loai_sp_id,
                size_id = (int)x.size_id,
                nhom_sp_id = (int)x.nhom_sp_id,
                Hinh_1 = x.Hinh_1,
                Hinh_2 = x.Hinh_2,
                Hinh_3 = x.Hinh_3,
                Hinh_4 = x.Hinh_4,
                Hinh_5 = x.Hinh_5,
                Hinh_6 = x.Hinh_6,
                Hinh_7 = x.Hinh_7,
                Hinh_8 = x.Hinh_8,
                Hinh_9 = x.Hinh_9,
                Hinh_10 = x.Hinh_10,

            }).ToList();
            if (lst_sanpham != null)
            {
                return new API_Results
                {
                    result = true,
                    data = lst_sanpham
                };
            }
            else
            {
                return new API_Results
                {
                    result = false,
                    data = "Get data failed"
                };
            }
        }
        [Route("{id}")]
        public API_Results GetByID(int id)
        {
            var sp = db.san_pham.FirstOrDefault(x => x.ID == id);
            if (sp != null)
            {
                sanphamvm data = new sanphamvm
                {
                    ID = sp.ID,
                    Code = sp.Code,
                    Name = sp.Name,
                    Gia = (float)sp.Gia,
                    Sale_off = (float)sp.Sale_off,
                    color_id = (int)sp.color_id,
                    trang_thai_sp_id = (int)sp.trang_thai_sp_id,
                    loai_sp_id = (int)sp.loai_sp_id,
                    size_id = (int)sp.size_id,
                    Hinh_1 = sp.Hinh_1,
                    Hinh_2 = sp.Hinh_2,
                    Hinh_3 = sp.Hinh_3,
                    Hinh_4 = sp.Hinh_4,
                    Hinh_5 = sp.Hinh_5,
                    Hinh_6 = sp.Hinh_6,
                    Hinh_7 = sp.Hinh_7,
                    Hinh_8 = sp.Hinh_8,
                    Hinh_9 = sp.Hinh_9,
                    Hinh_10 = sp.Hinh_10,
                    nhom_sp_id = (int)sp.nhom_sp_id,
                };
                return new API_Results
                {
                    result = true,
                    data = data
                };
            }
            else
            {
                return new API_Results
                {
                    result = false,
                    data = "Get Data Failed"
                };
            }
        }
        [Route("get8newsmen")]
        public API_Results Get8NewsMen()
        {
            List<sanphamvm> lst_sanpham = db.san_pham.Where(x => x.trang_thai_sp_id == 1 && x.nhom_sp_id == 1).Select(x => new sanphamvm
            {
                ID = x.ID,
                Code = x.Code,
                Name = x.Name,
                Gia = (float)x.Gia,
                Sale_off = (float)x.Sale_off,
                color_id = (int)x.color_id,
                trang_thai_sp_id = (int)x.trang_thai_sp_id,
                loai_sp_id = (int)x.loai_sp_id,
                size_id = (int)x.size_id,
                Hinh_1 = x.Hinh_1,
                Hinh_2 = x.Hinh_2,
                Hinh_3 = x.Hinh_3,
                Hinh_4 = x.Hinh_4,
                Hinh_5 = x.Hinh_5,
                Hinh_6 = x.Hinh_6,
                Hinh_7 = x.Hinh_7,
                Hinh_8 = x.Hinh_8,
                Hinh_9 = x.Hinh_9,
                Hinh_10 = x.Hinh_10,
                nhom_sp_id = (int)x.nhom_sp_id,
            }).Take(8).ToList();
            if (lst_sanpham != null)
            {
                return new API_Results
                {
                    result = true,
                    data = lst_sanpham
                };
            }
            else
            {
                return new API_Results
                {
                    result = false,
                    data = "Get Data Failed"
                };
            }
        }
        [Route("get8newswomen")]
        public API_Results Get8NewsWomen()
        {
            List<sanphamvm> lst_sanpham = db.san_pham.Where(x => x.trang_thai_sp_id == 1 && x.nhom_sp_id == 2).Select(x => new sanphamvm
            {
                ID = x.ID,
                Code = x.Code,
                Name = x.Name,
                Gia = (float)x.Gia,
                Sale_off = (float)x.Sale_off,
                color_id = (int)x.color_id,
                trang_thai_sp_id = (int)x.trang_thai_sp_id,
                loai_sp_id = (int)x.loai_sp_id,
                size_id = (int)x.size_id,
                Hinh_1 = x.Hinh_1,
                Hinh_2 = x.Hinh_2,
                Hinh_3 = x.Hinh_3,
                Hinh_4 = x.Hinh_4,
                Hinh_5 = x.Hinh_5,
                Hinh_6 = x.Hinh_6,
                Hinh_7 = x.Hinh_7,
                Hinh_8 = x.Hinh_8,
                Hinh_9 = x.Hinh_9,
                Hinh_10 = x.Hinh_10,
                nhom_sp_id = (int)x.nhom_sp_id,
            }).Take(8).ToList();
            if (lst_sanpham != null)
            {
                return new API_Results
                {
                    result = true,
                    data = lst_sanpham
                };
            }
            else
            {
                return new API_Results
                {
                    result = false,
                    data = "Get Data Failed"
                };
            }
        }
    }
}
