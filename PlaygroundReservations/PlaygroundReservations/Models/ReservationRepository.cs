using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace PlaygroundReservations.Models
{ 
    public class ReservationRepository : IReservationRepository
    {
        PlaygroundReservationsContext context;// = new PlaygroundReservationsContext();

		//If you are using Dependency Injection, you can delete the following constructor
		public ReservationRepository()
			:this(new PlaygroundReservationsContext())
		{}

		public ReservationRepository(PlaygroundReservationsContext context)
		{
			this.context = context;
		}

        public IQueryable<Reservation> All
        {
            get { return context.Reservations; }
        }

        public IQueryable<Reservation> AllIncluding(params Expression<Func<Reservation, object>>[] includeProperties)
        {
            IQueryable<Reservation> query = context.Reservations;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Reservation Find(int id)
        {
            return context.Reservations.Find(id);
        }

        public void InsertOrUpdate(Reservation reservation)
        {
            if (reservation.ReservationId == default(int)) {
                // New entity
                context.Reservations.Add(reservation);
            } else {
                // Existing entity
                context.Entry(reservation).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var reservation = context.Reservations.Find(id);
            context.Reservations.Remove(reservation);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IReservationRepository
    {
        IQueryable<Reservation> All { get; }
        IQueryable<Reservation> AllIncluding(params Expression<Func<Reservation, object>>[] includeProperties);
        Reservation Find(int id);
        void InsertOrUpdate(Reservation reservation);
        void Delete(int id);
        void Save();
    }
}