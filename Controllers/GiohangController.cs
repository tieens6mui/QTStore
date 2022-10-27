using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QTStore.Models;

namespace QTStore.Controllers
{
    public class GiohangController : Controller
    {
        dbQTStoreDataContext data = new dbQTStoreDataContext();
        // GET: Giohang
        public List<Giohang> GetGiohangs()
        {
            List<Giohang> lstGiohang = Session["Giohang"] as List<Giohang>;
            if (lstGiohang == null)
            {
                lstGiohang = new List<Giohang>();
                Session["Giohang"] = lstGiohang;
            }
            return lstGiohang;
        }

        public ActionResult Themgiohang(int iMaSP, string strURL)
        {
            SANPHAM sp = data.SANPHAMs.SingleOrDefault(n => n.MaSP == iMaSP);
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<Giohang> lstGiohang = GetGiohangs();
            Giohang sanpham = lstGiohang.Find(n => n.iMaSP == iMaSP);
            if (sanpham == null)
            {
                sanpham = new Giohang(iMaSP);
                //Add sản phẩm mới thêm vào list
                lstGiohang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.iSoluong++;
                return Redirect(strURL);
            }
        }
        public ActionResult CapNhatGioHang(int iMaSP, FormCollection f)
        {
            //Kiểm tra masp
            SANPHAM sp = data.SANPHAMs.SingleOrDefault(n => n.MaSP == iMaSP);
            //Nếu get sai masp thì sẽ trả về trang lỗi 404
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Lấy giỏ hàng ra từ session
            List<Giohang> lstGioHang = GetGiohangs();
            //Kiểm tra sp có tồn tại trong session["GioHang"]
            Giohang sanpham = lstGioHang.SingleOrDefault(n => n.iMaSP == iMaSP);
            //Nếu mà tồn tại thì chúng ta cho sửa số lượng
            if (sanpham != null)
            {
                sanpham.iSoluong = int.Parse(f["txtSoLuong"].ToString());

            }
            return RedirectToAction("Giohang");
        }
        public ActionResult XoaGioHang(int iMaSP)
        {
            //Kiểm tra masp
            SANPHAM sp = data.SANPHAMs.SingleOrDefault(n => n.MaSP == iMaSP);
            //Nếu get sai masp thì sẽ trả về trang lỗi 404
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Lấy giỏ hàng ra từ session
            List<Giohang> lstGioHang = GetGiohangs();
            Giohang sanpham = lstGioHang.SingleOrDefault(n => n.iMaSP == iMaSP);
            //Nếu mà tồn tại thì chúng ta cho sửa số lượng
            if (sanpham != null)
            {
                lstGioHang.RemoveAll(n => n.iMaSP == iMaSP);

            }
            if (lstGioHang.Count == 0)
            {
                return RedirectToAction("Index", "Store");
            }
            return RedirectToAction("Giohang");
        }
        public ActionResult GioHangPartial()
        {
            if (TongSoLuong() == 0)
            {
                return PartialView();
            }
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongTien = Tongtien();
            return PartialView();
        }
        public ActionResult Giohang()
        {
            List<Giohang> lstGiohang = GetGiohangs();
            if(lstGiohang.Count == 0)
            {
                return RedirectToAction("Index", "Store");
            }
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.Tongtien = Tongtien();
            return View(lstGiohang);
        }
        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<Giohang> lstGiohang = Session["Giohang"] as List<Giohang>;
            if (lstGiohang != null)
            {
                iTongSoLuong = lstGiohang.Sum(n => n.iSoluong);
            }
            return iTongSoLuong;
        }
        private double Tongtien()
        {
            double iTongtien = 0;
            List<Giohang> lstGiohang = Session["Giohang"] as List<Giohang>;
            if (lstGiohang != null)
            {
                iTongtien = lstGiohang.Sum(n => n.dThanhtien);
            }
            return iTongtien;
        }
        public ActionResult SuaGioHang()
        {
            if (Session["Giohang"] == null)
            {
                return RedirectToAction("Index", "Store");
            }
            List<Giohang> lstGioHang = GetGiohangs();
            return View(lstGioHang);

        }
        [HttpGet]
        public ActionResult Dathang()
        {
            if (Session["Taikhoan"] == null || Session["Taikhoan"].ToString() == "")
            {
                return RedirectToAction("Login", "User");
            }
            if (Session["Giohang"] == null)
            {
                RedirectToAction("Index", "Store");
            }
            List<Giohang> lstGiohang = GetGiohangs();
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.Tongtien = Tongtien();

            return View(lstGiohang);
        }
        public ActionResult Dathang(FormCollection collection)
        {
            DONDATHANG ddh = new DONDATHANG();
            KHACHHANG kh = (KHACHHANG)Session["Taikhoan"];
            List<Giohang> gh = GetGiohangs();
            ddh.MaKH = kh.MaKH;
            ddh.Ngaydat = DateTime.Now;
            var ngaygiao = String.Format("{0:mm/dd/yyy}", collection["Ngaygiao"]);
            ddh.Ngaygiao = DateTime.Parse(ngaygiao);
            ddh.Tinhtranggiaohang = false;
            ddh.Datthanhtoan = false;
            data.DONDATHANGs.InsertOnSubmit(ddh);
            data.SubmitChanges();
            foreach(var item in gh)
            {
                CHITIETDONHANG ctdh = new CHITIETDONHANG();
                ctdh.MaDonHang = ddh.MaDonHang;
                ctdh.MaSP = item.iMaSP;
                ctdh.Soluong = item.iSoluong;
                ctdh.Dongia = (decimal)item.iSoluong;
                data.CHITIETDONHANGs.InsertOnSubmit(ctdh);
            }
            data.SubmitChanges();
            Session["Giohang"] = null;
            return RedirectToAction("Xacnhandonhang", "Giohang");
        }
        public ActionResult Xacnhandonhang()
        {
            return View();
        }
    }
}