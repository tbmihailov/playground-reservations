using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlaygroundReservations.Models;

namespace PlaygroundReservations.Controllers
{   
    public class ReservationsController : Controller
    {
		private readonly IPlaygroundRepository playgroundRepository;
		private readonly ICustomerProfileRepository customerprofileRepository;
		private readonly IReservationRepository reservationRepository;

		// If you are using Dependency Injection, you can delete the following constructor
        public ReservationsController() : this(new PlaygroundRepository(), new CustomerProfileRepository(), new ReservationRepository())
        {
        }

        public ReservationsController(IPlaygroundRepository playgroundRepository, ICustomerProfileRepository customerprofileRepository, IReservationRepository reservationRepository)
        {
			this.playgroundRepository = playgroundRepository;
			this.customerprofileRepository = customerprofileRepository;
			this.reservationRepository = reservationRepository;
        }

        //
        // GET: /Reservations/

        public ViewResult Index()
        {
            return View(reservationRepository.AllIncluding(reservation => reservation.Playground, reservation => reservation.ReservedBy));
        }

        //
        // GET: /Reservations/Details/5

        public ViewResult Details(int id)
        {
            return View(reservationRepository.Find(id));
        }

        //
        // GET: /Reservations/Create

        public ActionResult Create()
        {
			ViewBag.PossiblePlaygrounds = playgroundRepository.All;
			ViewBag.PossibleReservedBies = customerprofileRepository.All;
            return View();
        } 

        //
        // POST: /Reservations/Create

        [HttpPost]
        public ActionResult Create(Reservation reservation)
        {
            if (ModelState.IsValid) {
                reservationRepository.InsertOrUpdate(reservation);
                reservationRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossiblePlaygrounds = playgroundRepository.All;
				ViewBag.PossibleReservedBies = customerprofileRepository.All;
				return View();
			}
        }
        
        //
        // GET: /Reservations/Edit/5
 
        public ActionResult Edit(int id)
        {
			ViewBag.PossiblePlaygrounds = playgroundRepository.All;
			ViewBag.PossibleReservedBies = customerprofileRepository.All;
             return View(reservationRepository.Find(id));
        }

        //
        // POST: /Reservations/Edit/5

        [HttpPost]
        public ActionResult Edit(Reservation reservation)
        {
            if (ModelState.IsValid) {
                reservationRepository.InsertOrUpdate(reservation);
                reservationRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossiblePlaygrounds = playgroundRepository.All;
				ViewBag.PossibleReservedBies = customerprofileRepository.All;
				return View();
			}
        }

        //
        // GET: /Reservations/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(reservationRepository.Find(id));
        }

        //
        // POST: /Reservations/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            reservationRepository.Delete(id);
            reservationRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

