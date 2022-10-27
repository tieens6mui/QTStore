using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QTStore.Models;

namespace QTStore.Controllers
{
    public class UserController : Controller
    {
        dbQTStoreDataContext data = new dbQTStoreDataContext();
        // GET: User
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Resign()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Resign(FormCollection collection, KHACHHANG kh)
        {
            var hoten = collection["HoTen"];
            var taikhoan = collection["Taikhoan"];
            var matkhau = collection["Matkhau"];
            var matkhaunhaplai = collection["Matkhaunhaplai"];
            var email = collection["Email"];
            var diachi = collection["DiachiKH"];
            var dienthoai = collection["DienthoaiKH"];
            var ngaysinh = string.Format("{0:MM/dd/yyyy}", collection["Ngaysinh"]);
            if (string.IsNullOrEmpty(hoten))
            {
                ViewData["Loi1"] = "Họ tên khách hàng không được để trống";
            }
            else if (string.IsNullOrEmpty(taikhoan))
            {
                ViewData["Loi2"] = "Phải có tên đăng nhập";
            }
            else if (string.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi3"] = "Phải nhập mật khẩu";
            }
            else if (string.IsNullOrEmpty(matkhaunhaplai))
            {
                ViewData["Loi4"] = "Phải nhập lại mật khẩu";
            }
            else if (string.IsNullOrEmpty(email))
            {
                ViewData["Loi5"] = "Bạn phải nhập email";
            }
            else if (string.IsNullOrEmpty(diachi))
            {
                ViewData["Loi6"] = "Bạn phải nhập địa chỉ";
            }
            else if (string.IsNullOrEmpty(dienthoai))
            {
                ViewData["Loi7"] = "Bạn phải nhập số điện thoại";
            }
            else
            {
                kh.HoTen = hoten;
                kh.Taikhoan = taikhoan;
                kh.Matkhau = matkhau;
                kh.Email = email;
                kh.DiachiKH = diachi;
                kh.DienthoaiKH = dienthoai;
                kh.Ngaysinh = DateTime.Parse(ngaysinh);
                data.KHACHHANGs.InsertOnSubmit(kh);
                data.SubmitChanges();
                return RedirectToAction("Login");
            }
            return this.Resign();
        }
        public ActionResult Login(FormCollection collection, KHACHHANG kh)
        {
            var Taikhoan = collection["Taikhoan"];
            var Matkhau = collection["Matkhau"];
            if (string.IsNullOrEmpty(Taikhoan))
            {
                ViewData["Loi1"] = "Bạn phải nhập tài khoản";
            }
            else if (string.IsNullOrEmpty(Matkhau))
            {
                ViewData["Loi2"] = "Bạn phải nhập mật khẩu";
            }
            else
            {
                kh = data.KHACHHANGs.SingleOrDefault(n => n.Taikhoan == Taikhoan && n.Matkhau == Matkhau);
                if (kh != null)
                {
                    Session["Taikhoankhach"] = kh;
                    ViewBag.Thongbao = "Đăng nhập thành công";
                    return RedirectToAction("Index", "Store");
                    // return RedirectToAction("Index", "PhoneShop");
                }
                else
                    ViewBag.Thongbao = "Tên tài khoản hoặc mật khẩu không đúng";
            }
            return View();
        }
        
    }
}