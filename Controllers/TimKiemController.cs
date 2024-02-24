using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using WebBanHangOnline.Models.EF;

using PagedList;

namespace WebBanHangOnline.Controllers
{
    public class TimKiemController : Controller
    {
        // GET: TimKiem
        private ApplicationDbContext db = new ApplicationDbContext();


        /* public ActionResult SearchPhanTrang(int? page, string strSearch = null)
         {
             ViewBag.Sreach = strSearch;
             if (!string.IsNullOrEmpty(strSearch))
             {
                 int iSize = 3;
                 int iPageNumber = (page ?? 1);
                 var kq = from s in db.Products where s.Title.Contains(strSearch) || s.Description.Contains(strSearch) select s;
                 return View(kq.ToPagedList(iPageNumber, iSize));
             }
             return View();
         }*/
        public ActionResult TimKiem(string strSearch)
        {
            ViewBag.Search = strSearch;
            if (!string.IsNullOrEmpty(strSearch))
            {
                //var kq = from s in data.SACHes where s.TenSach.Contains(strSearch) select s;//var kq = db.SACHes…
                var kq = from s in db.Products where s.Title.Contains(strSearch) || s.Description.Contains(strSearch) select s;
                return View(kq);
            }
            return View();
        }
    }
}