using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlaygroundReservations.Models;

namespace PlaygroundReservations.Controllers
{   
    public class OwnerProfilesController : Controller
    {
		private readonly IOwnerProfileRepository ownerprofileRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public OwnerProfilesController() : this(new OwnerProfileRepository())
        {
        }

        public OwnerProfilesController(IOwnerProfileRepository ownerprofileRepository)
        {
			this.ownerprofileRepository = ownerprofileRepository;
        }

        //
        // GET: /OwnerProfiles/

        public ViewResult Index()
        {
            return View(ownerprofileRepository.All);
        }

        //
        // GET: /OwnerProfiles/Details/5

        public ViewResult Details(int id)
        {
            return View(ownerprofileRepository.Find(id));
        }

        //
        // GET: /OwnerProfiles/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /OwnerProfiles/Create

        [HttpPost]
        public ActionResult Create(OwnerProfile ownerprofile)
        {
            if (ModelState.IsValid) {
                ownerprofileRepository.InsertOrUpdate(ownerprofile);
                ownerprofileRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /OwnerProfiles/Edit/5
 
        public ActionResult Edit(int id)
        {
             return View(ownerprofileRepository.Find(id));
        }

        //
        // POST: /OwnerProfiles/Edit/5

        [HttpPost]
        public ActionResult Edit(OwnerProfile ownerprofile)
        {
            if (ModelState.IsValid) {
                ownerprofileRepository.InsertOrUpdate(ownerprofile);
                ownerprofileRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /OwnerProfiles/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(ownerprofileRepository.Find(id));
        }

        //
        // POST: /OwnerProfiles/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ownerprofileRepository.Delete(id);
            ownerprofileRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

