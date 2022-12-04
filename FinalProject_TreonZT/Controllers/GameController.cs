using FinalProject_TreonZT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_TreonZT.Controllers
{
    public class GameController : Controller
    {

        private GameContext context;


        public GameController(GameContext ctx)
        {
            context = ctx;


        }


        
        public ActionResult Index()
        {
            return RedirectToAction("List", "Game");
        }


        public IActionResult List(List<Game> games, string id = "All")
        {

            if (id == "All")
            {
                games = context.Games
                    .OrderBy(p => p.GameId).ToList();
            }



            var model = new GameListViewModel
            {

                Games = games,

            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Game());
        }


    

        [HttpGet]
       


     public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var game =context.Games.Find(id);
            return View(game);
        }
        [HttpPost]
        public IActionResult Edit(Game game)
        {
            if (ModelState.IsValid)
            {
                if (game.GameId == 0)
                    context.Games.Add(game);
            

            else
            
                context.Games.Update(game);
                context.SaveChanges();
                return RedirectToAction("List", "Game"); }
            
            else
            { 
                ViewBag.Action = (game.GameId == 0) ? "Add" : "Edit";
                
                return View(game);
            }
        }

        


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var game = context.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            context.Games.Remove(game);
            context.SaveChanges();
            return RedirectToAction("List", "Game");
        }


    }
}
