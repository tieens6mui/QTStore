using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QTStore.Models
{
    public class Giohang
    {
        dbQTStoreDataContext data = new dbQTStoreDataContext();
        public int iMaSP { set; get; }
        public string sTenSP { set; get; }
        public string sAnhbia { set; get; }
        public double dGiaban { set; get; }
        public int iSoluong { set; get; }
        public double dThanhtien
        {
            get { return iSoluong * dGiaban; }
        }
        public Giohang(int MaSP)
        {
            iMaSP = MaSP;
            SANPHAM sp = data.SANPHAMs.Single(n => n.MaSP == iMaSP);
            sTenSP = sp.TenSP;
            sAnhbia = sp.Anhbia;
            dGiaban = double.Parse(sp.Giaban.ToString());
            iSoluong = 1;
        }
    }
}