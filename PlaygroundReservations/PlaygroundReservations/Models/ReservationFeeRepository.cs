using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace PlaygroundReservations.Models
{ 
    public class ReservationFeeRepository : IReservationFeeRepository
    {
        PlaygroundReservationsContext context;// = new PlaygroundReservationsContext();

		//If you are using Dependency Injection, you can delete the following constructor
		public ReservationFeeRepository()
			:this(new PlaygroundReservationsContext())
		{}

		public ReservationFeeRepository(PlaygroundReservationsContext context)
		{
			this.context = context;
		}

        public IQueryable<ReservationFee> All
        {
            get { return context.ReservationFees; }
        }

        public IQueryable<ReservationFee> AllIncluding(params Expression<Func<ReservationFee, object>>[] includeProperties)
        {
            IQueryable<ReservationFee> query = context.ReservationFees;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ReservationFee Find(int id)
        {
            return context.ReservationFees.Find(id);
        }

        public void InsertOrUpdate(ReservationFee reservationfee)
        {
            if (reservationfee.ReservationFeeId == default(int)) {
                // New entity
                context.ReservationFees.Add(reservationfee);
            } else {
                // Existing entity
                context.Entry(reservationfee).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var reservationfee = context.ReservationFees.Find(id);
            context.ReservationFees.Remove(reservationfee);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IReservationFeeRepository
    {
        IQueryable<ReservationFee> All { get; }
        IQueryable<ReservationFee> AllIncluding(params Expression<Func<ReservationFee, object>>[] includeProperties);
        ReservationFee Find(int id);
        void InsertOrUpdate(ReservationFee reservationfee);
        void Delete(int id);
        void Save();
    }
}