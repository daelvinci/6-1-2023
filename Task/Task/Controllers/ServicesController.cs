using Microsoft.AspNetCore.Mvc;
using Task.Models;

namespace Task.Controllers
{
    public class ServicesController:Controller
    {
        public ActionResult Index()
        {
            return View(Data.services);
        }
    }
}
