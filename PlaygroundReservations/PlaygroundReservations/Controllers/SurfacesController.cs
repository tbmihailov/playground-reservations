using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlaygroundReservations.Models;

namespace PlaygroundReservations.Controllers
{   
    public class SurfacesController : Controller
    {
		private readonly ISurfaceRepository surfaceRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public SurfacesController() : this(new SurfaceRepository())
        {
        }

        public SurfacesController(ISurfaceRepository surfaceRepository)
        {
			this.surfaceRepository = surfaceRepository;
        }

        //
        // GET: /Surfaces/

        public ViewResult Index()
        {
            return View(surfaceRepository.All);
        }

        //
        // GET: /Surfaces/Details/5

        public ViewResult Details(int id)
        {
            return View(surfaceRepository.Find(id));
        }

        //
        // GET: /Surfaces/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Surfaces/Create

        [HttpPost]
        public ActionResult Create(Surface surface)
        {
            if (ModelState.IsValid) {
                surfaceRepository.InsertOrUpdate(surface);
                surfaceRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Surfaces/Edit/5
 
        public ActionResult Edit(int id)
        {
             return View(surfaceRepository.Find(id));
        }

        //
        // POST: /Surfaces/Edit/5

        [HttpPost]
        public ActionResult Edit(Surface surface)
        {
            if (ModelState.IsValid) {
                surfaceRepository.InsertOrUpdate(surface);
                surfaceRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Surfaces/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(surfaceRepository.Find(id));
        }

        //
        // POST: /Surfaces/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            surfaceRepository.Delete(id);
            surfaceRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

