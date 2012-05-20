using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlaygroundReservations.Models;

namespace PlaygroundReservations.Controllers
{   
    public class ReservationFeesController : Controller
    {
		private readonly IPlaygroundRepository playgroundRepository;
		private readonly IReservationFeeRepository reservationfeeRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public ReservationFeesController() : this(new PlaygroundRepository(), new ReservationFeeRepository())
        {
        }

        public ReservationFeesController(IPlaygroundRepository playgroundRepository, IReservationFeeRepository reservationfeeRepository)
        {
			this.playgroundRepository = playgroundRepository;
			this.reservationfeeRepository = reservationfeeRepository;
        }

        //
        // GET: /ReservationFees/

        public ViewResult Index()
        {
            return View(reservationfeeRepository.AllIncluding(reservationfee => reservationfee.Playground));
        }

        //
        // GET: /ReservationFees/Details/5

        public ViewResult Details(int id)
        {
            return View(reservationfeeRepository.Find(id));
        }

        //
        // GET: /ReservationFees/Create

        public ActionResult Create()
        {
			ViewBag.PossiblePlaygrounds = playgroundRepository.All;
            return View();
        } 

        //
        // POST: /ReservationFees/Create

        [HttpPost]
        public ActionResult Create(ReservationFee reservationfee)
        {
            if (ModelState.IsValid) {
                reservationfeeRepository.InsertOrUpdate(reservationfee);
                reservationfeeRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossiblePlaygrounds = playgroundRepository.All;
				return View();
			}
        }
        
        //
        // GET: /ReservationFees/Edit/5
 
        public ActionResult Edit(int id)
        {
			ViewBag.PossiblePlaygrounds = playgroundRepository.All;
             return View(reservationfeeRepository.Find(id));
        }

        //
        // POST: /ReservationFees/Edit/5

        [HttpPost]
        public ActionResult Edit(ReservationFee reservationfee)
        {
            if (ModelState.IsValid) {
                reservationfeeRepository.InsertOrUpdate(reservationfee);
                reservationfeeRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossiblePlaygrounds = playgroundRepository.All;
				return View();
			}
        }

        //
        // GET: /ReservationFees/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(reservationfeeRepository.Find(id));
        }

        //
        // POST: /ReservationFees/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            reservationfeeRepository.Delete(id);
            reservationfeeRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

