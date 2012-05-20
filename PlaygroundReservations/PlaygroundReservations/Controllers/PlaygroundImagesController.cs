using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlaygroundReservations.Models;

namespace PlaygroundReservations.Controllers
{   
    public class PlaygroundImagesController : Controller
    {
		private readonly IPlaygroundRepository playgroundRepository;
		private readonly IPlaygroundImageRepository playgroundimageRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public PlaygroundImagesController() : this(new PlaygroundRepository(), new PlaygroundImageRepository())
        {
        }

        public PlaygroundImagesController(IPlaygroundRepository playgroundRepository, IPlaygroundImageRepository playgroundimageRepository)
        {
			this.playgroundRepository = playgroundRepository;
			this.playgroundimageRepository = playgroundimageRepository;
        }

        //
        // GET: /PlaygroundImages/

        public ViewResult Index()
        {
            return View(playgroundimageRepository.AllIncluding(playgroundimage => playgroundimage.Playground));
        }

        //
        // GET: /PlaygroundImages/Details/5

        public ViewResult Details(int id)
        {
            return View(playgroundimageRepository.Find(id));
        }

        //
        // GET: /PlaygroundImages/Create

        public ActionResult Create()
        {
			ViewBag.PossiblePlaygrounds = playgroundRepository.All;
            return View();
        } 

        //
        // POST: /PlaygroundImages/Create

        [HttpPost]
        public ActionResult Create(PlaygroundImage playgroundimage)
        {
            if (ModelState.IsValid) {
                playgroundimageRepository.InsertOrUpdate(playgroundimage);
                playgroundimageRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossiblePlaygrounds = playgroundRepository.All;
				return View();
			}
        }
        
        //
        // GET: /PlaygroundImages/Edit/5
 
        public ActionResult Edit(int id)
        {
			ViewBag.PossiblePlaygrounds = playgroundRepository.All;
             return View(playgroundimageRepository.Find(id));
        }

        //
        // POST: /PlaygroundImages/Edit/5

        [HttpPost]
        public ActionResult Edit(PlaygroundImage playgroundimage)
        {
            if (ModelState.IsValid) {
                playgroundimageRepository.InsertOrUpdate(playgroundimage);
                playgroundimageRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossiblePlaygrounds = playgroundRepository.All;
				return View();
			}
        }

        //
        // GET: /PlaygroundImages/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(playgroundimageRepository.Find(id));
        }

        //
        // POST: /PlaygroundImages/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            playgroundimageRepository.Delete(id);
            playgroundimageRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

