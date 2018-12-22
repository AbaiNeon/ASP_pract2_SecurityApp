using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace SecurityApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public async Task<ActionResult> Index()
        {
            return File(@"C:\Users\ТогузбаевА\Downloads\MobApp-colorlib.zip", "application/zip");
        }
    }
}