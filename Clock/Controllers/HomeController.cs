using System;
using System.Web.Mvc;

namespace Clock.Controllers
{
    public class HomeController : Controller
    {
        public static DateTime CurrentDateTime;
        public static int Decrement = 0;

        public ActionResult Index()
        {
            CurrentDateTime = DateTime.Now;
            Decrement = 0;

            ViewBag.Hour = CurrentDateTime.Hour < 10 ? "0" + CurrentDateTime.Hour.ToString() : CurrentDateTime.Hour.ToString();
            ViewBag.Min = CurrentDateTime.Minute < 10 ? "0" + CurrentDateTime.Minute.ToString() : CurrentDateTime.Minute.ToString();
            ViewBag.Sec = CurrentDateTime.Second < 10 ? "0" + CurrentDateTime.Second.ToString() : CurrentDateTime.Second.ToString();

            return View();
        }

        [HttpPost]
        [Route("ClockTick")]
        public JsonResult ClockTick()
        {
            if (Decrement == 0)
            {
                CurrentDateTime = CurrentDateTime.AddSeconds(1);
            }
            else
            {
                double boolDecrement = Convert.ToDouble(Decrement * -1);
                CurrentDateTime = CurrentDateTime.AddSeconds(boolDecrement);
            }

            return Json(new {
                Hour = CurrentDateTime.Hour < 10 ? "0" + CurrentDateTime.Hour.ToString() : CurrentDateTime.Hour.ToString(),
                Min = CurrentDateTime.Minute < 10 ? "0" + CurrentDateTime.Minute.ToString() : CurrentDateTime.Minute.ToString(),
                Sec = CurrentDateTime.Second < 10 ? "0" + CurrentDateTime.Second.ToString() : CurrentDateTime.Second.ToString()
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [Route("ClockDecrement")]
        public bool ClockDecrement(int decrement)
        {
            Decrement = decrement;
            return true;
        }
    }
}