using Microsoft.AspNetCore.Mvc;
using Task.Models;

namespace Task.Controllers
{
    public class TeamController:Controller
    {
        public ActionResult Index()
        {
            return View(Data.teams);
        }
        public ActionResult Detail(int id)
        {
            Team team = Data.teams.Find(x => x.Id == id);
            return View(team);
        }
    }
}
