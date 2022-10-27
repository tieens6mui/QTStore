using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QTStore.Models;

namespace QTStore.Controllers
{
    public class StoreController : Controller
    {
        dbQTStoreDataContext data = new dbQTStoreDataContext();
        //Tạo list sản phẩm
        private List<SANPHAM> Laysanphammoi(int count)
        {
            //Sắp xếp theo ngày cập nhật
            return data.SANPHAMs.OrderByDescending(a => a.Ngaycapnhat).Take(count).ToList();
        }
        // GET: Store
        //Trang chủ
        public ActionResult Index()
        {
            return View();
        }
        //Trang about
        public ActionResult About()
        {
            return View();
        }
        //Trang sản phẩm
        public ActionResult Shop()
        {
            var sanphammoi = Laysanphammoi(6); 
            return View(sanphammoi);
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult LoaiSP() 
        {
            var loaisp = from lsp in data.LOAISPs select lsp;
            return PartialView(loaisp);
        }
        public ActionResult NhaSX()
        {
            var nhasx = from nsx in data.NHASANXUATs select nsx;
            return PartialView(nhasx);
        }
        public ActionResult Khuyenmai()
        {
            var khuyenmai = from km in data.KHUYEMMAIs select km;
            return PartialView(khuyenmai);
        }
        public ActionResult SPTheoLoaiSP(int id)
        {
            var sp = from s in data.SANPHAMs where s.MaLSP == id select s;
            return View(sp);
        }
        public ActionResult SPTheoNSX(int id)
        {
            var sp = from s in data.SANPHAMs where s.MaNSX == id select s;
            return View(sp);
        }
        public ActionResult SPTheoKM(int id)
        {
            var sp = from s in data.SANPHAMs where s.MaKM == id select s;
            return View(sp);
        }
        public ActionResult Details(int MaSP = 0)
        {
            var chitiet = data.SANPHAMs.SingleOrDefault(n => n.MaSP == MaSP);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }
    }
}