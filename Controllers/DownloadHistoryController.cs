using Newtonsoft.Json;
using Scheduler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scheduler.Controllers
{
    public class DownloadHistoryController : Controller
    {
        DownloadHistory db = new DownloadHistory();
        // GET: DownloadHistory
        public ActionResult Index()
        {
            var downloadhistorylist = db.tbl_downloadhistory.ToList();
            ViewBag.downloadhis = downloadhistorylist;
            return View();
        }
        public JsonResult getdata()
        {
            var downloadhistorylist = db.tbl_downloadhistory.ToList().OrderByDescending(x => x.ID);
            ViewBag.downloadhis = downloadhistorylist;
            var json = JsonConvert.SerializeObject(downloadhistorylist);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}