using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlaygroundReservations.Models;

namespace PlaygroundReservations.Controllers
{
    public class PlaygroundsController : Controller
    {
        private readonly ISportComplexRepository sportcomplexRepository;
        private readonly ISurfaceRepository surfaceRepository;
        private readonly IPlaygroundRepository playgroundRepository;

        // If you are using Dependency Injection, you can delete the following constructor
        public PlaygroundsController()
            : this(new SportComplexRepository(), new SurfaceRepository(), new PlaygroundRepository())
        {
        }

        public PlaygroundsController(ISportComplexRepository sportcomplexRepository, ISurfaceRepository surfaceRepository, IPlaygroundRepository playgroundRepository)
        {
            this.sportcomplexRepository = sportcomplexRepository;
            this.surfaceRepository = surfaceRepository;
            this.playgroundRepository = playgroundRepository;
        }

        //
        // GET: /Playgrounds/

        public ViewResult Index()
        {
            return View(playgroundRepository.AllIncluding(playground => playground.SportComplex, playground => playground.Surface));
        }

        //
        // GET: /Playgrounds/Details/5

        public ViewResult Details(int id)
        {
            return View(playgroundRepository.Find(id));
        }

        //
        // GET: /Playgrounds/Create

        public ActionResult Create()
        {
            ViewBag.PossibleSportComplexes = sportcomplexRepository.All;
            ViewBag.PossibleSurfaces = surfaceRepository.All;
            return View();
        }

        //
        // POST: /Playgrounds/Create

        [HttpPost]
        public ActionResult Create(Playground playground)
        {
            if (ModelState.IsValid)
            {
                if (playground.SportTypeId == 0)
                {
                    playground.SportTypeId = 1;
                }
                playgroundRepository.InsertOrUpdate(playground);
                playgroundRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.PossibleSportComplexes = sportcomplexRepository.All;
                ViewBag.PossibleSurfaces = surfaceRepository.All;
                return View();
            }
        }

        //
        // GET: /Playgrounds/Edit/5

        public ActionResult Edit(int id)
        {
            ViewBag.PossibleSportComplexes = sportcomplexRepository.All;
            ViewBag.PossibleSurfaces = surfaceRepository.All;
            return View(playgroundRepository.Find(id));
        }

        //
        // POST: /Playgrounds/Edit/5

        [HttpPost]
        public ActionResult Edit(Playground playground)
        {
            if (ModelState.IsValid)
            {
                playgroundRepository.InsertOrUpdate(playground);
                playgroundRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.PossibleSportComplexes = sportcomplexRepository.All;
                ViewBag.PossibleSurfaces = surfaceRepository.All;
                return View();
            }
        }

        //
        // GET: /Playgrounds/Delete/5

        public ActionResult Delete(int id)
        {
            return View(playgroundRepository.Find(id));
        }

        //
        // POST: /Playgrounds/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            playgroundRepository.Delete(id);
            playgroundRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

