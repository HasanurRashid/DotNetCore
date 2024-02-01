using FirstDemo.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace FirstDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;

        public HomeController(ILogger<HomeController> logger, IEmailSender emailSender,ISmsSender smsSender)
        {
            _logger = logger;
            _emailSender= emailSender;
            _smsSender = smsSender; 

        }

        public IActionResult Index()
        {
            var rawStringLiteral = """ This is Hasan""";
            
            var model = new IndexModel();
            model.Message = "Hello World";

            return View(model);
        }

        public IActionResult Test()
        {
            var model = new TestModels();
            model.Email = "hasan@gamil.com";
            return View(model);
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Test(TestModels model)
        {
            if (ModelState.IsValid)
            {
                int x = 10;
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}