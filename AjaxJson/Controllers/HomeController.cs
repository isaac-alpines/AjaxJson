using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxJson.Controllers
{
    public class HomeController : Controller
    {
        private List<string> listData = new List<string>() { "apple", "samsung", "xiaomi", "huawei", "asus" };

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
            return Json(listData, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SetData(string listItem)
        {
            if (listItem != null)
            {
                listData.Add(listItem);
            }

            return Json(listData, JsonRequestBehavior.AllowGet);
        }
    }
}