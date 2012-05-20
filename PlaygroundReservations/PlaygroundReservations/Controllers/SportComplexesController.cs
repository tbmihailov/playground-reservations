using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlaygroundReservations.Models;

namespace PlaygroundReservations.Controllers
{   
    public class SportComplexesController : Controller
    {
		private readonly IOwnerProfileRepository ownerprofileRepository;
		private readonly ISportComplexRepository sportcomplexRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public SportComplexesController() : this(new OwnerProfileRepository(), new SportComplexRepository())
        {
        }

        public SportComplexesController(IOwnerProfileRepository ownerprofileRepository, ISportComplexRepository sportcomplexRepository)
        {
			this.ownerprofileRepository = ownerprofileRepository;
			this.sportcomplexRepository = sportcomplexRepository;
        }

        //
        // GET: /SportComplexes/

        public ViewResult Index()
        {
            return View(sportcomplexRepository.AllIncluding(sportcomplex => sportcomplex.Owner));
        }

        //
        // GET: /SportComplexes/Details/5

        public ViewResult Details(int id)
        {
            return View(sportcomplexRepository.Find(id));
        }

        //
        // GET: /SportComplexes/Create

        public ActionResult Create()
        {
			ViewBag.PossibleOwners = ownerprofileRepository.All;
            return View();
        } 

        //
        // POST: /SportComplexes/Create

        [HttpPost]
        public ActionResult Create(SportComplex sportcomplex)
        {
            if (ModelState.IsValid) {
                sportcomplexRepository.InsertOrUpdate(sportcomplex);
                sportcomplexRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleOwners = ownerprofileRepository.All;
				return View();
			}
        }
        
        //
        // GET: /SportComplexes/Edit/5
 
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleOwners = ownerprofileRepository.All;
             return View(sportcomplexRepository.Find(id));
        }

        //
        // POST: /SportComplexes/Edit/5

        [HttpPost]
        public ActionResult Edit(SportComplex sportcomplex)
        {
            if (ModelState.IsValid) {
                sportcomplexRepository.InsertOrUpdate(sportcomplex);
                sportcomplexRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleOwners = ownerprofileRepository.All;
				return View();
			}
        }

        //
        // GET: /SportComplexes/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(sportcomplexRepository.Find(id));
        }

        //
        // POST: /SportComplexes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            sportcomplexRepository.Delete(id);
            sportcomplexRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

