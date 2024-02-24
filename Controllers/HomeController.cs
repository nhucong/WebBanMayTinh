using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using WebBanHangOnline.Models.EF;

namespace WebBanHangOnline.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
          
            //WebBanHangOnline.Common.Common.SendMail("ABC", "AAAA", "AAAA", "ngohoang29@gmail.com");
            return View();
        }

      
    }
}