using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QTStore.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;

namespace QTStore.Controllers
{
    public class AdminController : Controller
    {
        dbQTStoreDataContext data = new dbQTStoreDataContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product(int ?page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 7;
            //return View(data.SANPHAMs.ToList());
            return View(data.SANPHAMs.ToList().OrderBy(n => n.MaSP).ToPagedList(pageNumber, pageSize));
        }

        [HttpGet]
        public ActionResult Login(FormCollection collection)
        {
            var tendn = collection["username"];
            var matkhau = collection["password"];
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Phải nhập tên đăng nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mật khẩu";
            }
            else
            {
                Admin ad = data.Admins.SingleOrDefault(n => n.UserAdmin == tendn && n.PassAdmin == matkhau);
                if (ad != null)
                {
                    Session["Taikhoanadmin"] = ad;
                    return RedirectToAction("Index", "Admin");
                }
                else
                    ViewBag.Thongbao = "Sai tên tài khoản hoặc mật khẩu";
            }
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.MaLSP = new SelectList(data.LOAISPs.ToList().OrderBy(n => n.TenLSP), "MaLSP", "TenLSP");
            ViewBag.MaNSX = new SelectList(data.NHASANXUATs.ToList().OrderBy(n => n.TenNSX), "MaNSX", "TenNSX");
            ViewBag.MaKM = new SelectList(data.KHUYEMMAIs.ToList().OrderBy(n => n.TenKM), "MaKM", "TenKM");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(SANPHAM sp, HttpPostedFileBase fileupload)
        {
            ViewBag.MaLSP = new SelectList(data.LOAISPs.ToList().OrderBy(n => n.TenLSP), "MaLSP", "TenLSP");
            ViewBag.MaNSX = new SelectList(data.NHASANXUATs.ToList().OrderBy(n => n.TenNSX), "MaNSX", "TenNSX");
            ViewBag.MaKM = new SelectList(data.KHUYEMMAIs.ToList().OrderBy(n => n.TenKM), "MaKM", "TenKM");
            if(fileupload == null)
            {
                ViewBag.Thongbao = "Vui lòng chọn ảnh";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(fileupload.FileName);
                    var path = Path.Combine(Server.MapPath("~/Images"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Thongbao = "Hình đã tồn tại";
                    }
                    else
                    {
                        fileupload.SaveAs(path);
                    }
                    sp.Anhbia = fileName;
                    data.SANPHAMs.InsertOnSubmit(sp);
                    data.SubmitChanges();
                }
                return RedirectToAction("Product");
            }
        }
        public ActionResult Details(int id)
        {
            SANPHAM sp = data.SANPHAMs.SingleOrDefault(n => n.MaSP == id);
            ViewBag.MaSP = sp.MaSP;
            if(sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }
        public ActionResult Delete(int id)
        {
            SANPHAM sp = data.SANPHAMs.SingleOrDefault(n => n.MaSP == id);
            ViewBag.MaSP = sp.MaSP;
            if(sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            SANPHAM sp = data.SANPHAMs.SingleOrDefault(n => n.MaSP == id);
            ViewBag.MaSP = sp.MaSP;
            if(sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            data.SANPHAMs.DeleteOnSubmit(sp);
            data.SubmitChanges();
            return RedirectToAction("SANPHAM");
        }
        public ActionResult Edit(int id)
        {
            dbQTStoreDataContext data = new dbQTStoreDataContext();
            SANPHAM sp = data.SANPHAMs.FirstOrDefault(x => x.MaSP == id);
            if (Request.Form.Count == 0)
            {
                return View(sp);
            }
            sp.MaSP = int.Parse(Request.Form["MaSP"]);
            sp.TenSP = Request.Form["TenSP"];
            sp.Giaban = decimal.Parse(Request.Form["Giaban"]);
            sp.Mota =  Request.Form["UnitPrice"];
            sp.Anhbia = Request.Form["Anhbia"];
            sp.Ngaycapnhat = DateTime.Parse(Request.Form["Ngaycapnhat"]);
            sp.Soluongton = int.Parse(Request.Form["Soluongton"]);
            ViewBag.MaLSP = new SelectList(data.LOAISPs.ToList().OrderBy(n => n.TenLSP), "MaLSP", "TenLSP");
            ViewBag.MaNSX = new SelectList(data.NHASANXUATs.ToList().OrderBy(n => n.TenNSX), "MaNSX", "TenNSX");
            ViewBag.MaKM = new SelectList(data.KHUYEMMAIs.ToList().OrderBy(n => n.TenKM), "MaKM", "TenKM");
            HttpPostedFileBase file = Request.Files["Picture"];
            if (file != null && file.FileName != "")
            {
                string serverPath = HttpContext.Server.MapPath("~/Images/");
                string filePath = serverPath + "/" + file.FileName;
                file.SaveAs(filePath);
                sp.Anhbia = file.FileName;
            }
            data.SubmitChanges();
            return RedirectToAction("Index");
        }
    }
}