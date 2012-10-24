using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SampleServiceClient;

namespace SampleMvcApp.Controllers
{
    public class HomeController : Controller
    {
        StringHelper _helper;

        public HomeController()
        {
            _helper = new StringHelper();
        }

        public HomeController(StringHelper helper)
        {
            _helper = helper;
        }
        
        public async Task<ActionResult> Index()
        {
            ViewBag.Message = "Reversed 'abc' string: " + await _helper.ReverseAsync("abc");
            return View();
        }
    }
}
