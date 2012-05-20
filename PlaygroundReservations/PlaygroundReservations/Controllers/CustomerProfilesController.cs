using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlaygroundReservations.Models;

namespace PlaygroundReservations.Controllers
{   
    public class CustomerProfilesController : Controller
    {
		private readonly ICustomerProfileRepository customerprofileRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public CustomerProfilesController() : this(new CustomerProfileRepository())
        {
        }

        public CustomerProfilesController(ICustomerProfileRepository customerprofileRepository)
        {
			this.customerprofileRepository = customerprofileRepository;
        }

        //
        // GET: /CustomerProfiles/

        public ViewResult Index()
        {
            return View(customerprofileRepository.All);
        }

        //
        // GET: /CustomerProfiles/Details/5

        public ViewResult Details(int id)
        {
            return View(customerprofileRepository.Find(id));
        }

        //
        // GET: /CustomerProfiles/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /CustomerProfiles/Create

        [HttpPost]
        public ActionResult Create(CustomerProfile customerprofile)
        {
            if (ModelState.IsValid) {
                customerprofileRepository.InsertOrUpdate(customerprofile);
                customerprofileRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /CustomerProfiles/Edit/5
 
        public ActionResult Edit(int id)
        {
             return View(customerprofileRepository.Find(id));
        }

        //
        // POST: /CustomerProfiles/Edit/5

        [HttpPost]
        public ActionResult Edit(CustomerProfile customerprofile)
        {
            if (ModelState.IsValid) {
                customerprofileRepository.InsertOrUpdate(customerprofile);
                customerprofileRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /CustomerProfiles/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(customerprofileRepository.Find(id));
        }

        //
        // POST: /CustomerProfiles/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            customerprofileRepository.Delete(id);
            customerprofileRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

