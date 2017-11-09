using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NeverMpilo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var xmlFile = Server.MapPath("/ClientDetails.xml");
            var clientDetails = BusinessLogic.BusinessLogic.GetCLient(xmlFile);
            TempData["details"] = clientDetails;
            return View();
        }

        [HttpPost]
        public JsonResult SaveData(BusinessLogic.Models.Client data)
        {
            string res = "";

            try
            {
                var surname = Request.Form["Surname"];
               // dblayer.Add_register(rs);
                res = "Successfully saved";
            }

            catch (Exception ex)
            {
                res = "Failed - "+ ex.Message;
            }

            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}
