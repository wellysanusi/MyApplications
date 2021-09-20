using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clock.Controllers;

namespace Clock.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ClockTick()
        {
            HomeController controller = new HomeController();
            JsonResult result = controller.ClockTick() as JsonResult;
            Assert.IsNotNull(result);
        }
    }
}
