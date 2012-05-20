using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace PlaygroundReservations.Models
{ 
    public class CustomerProfileRepository : ICustomerProfileRepository
    {
        PlaygroundReservationsContext context;// = new PlaygroundReservationsContext();

		//If you are using Dependency Injection, you can delete the following constructor
		public CustomerProfileRepository()
			:this(new PlaygroundReservationsContext())
		{}

		public CustomerProfileRepository(PlaygroundReservationsContext context)
		{
			this.context = context;
		}

        public IQueryable<CustomerProfile> All
        {
            get { return context.CustomerProfiles; }
        }

        public IQueryable<CustomerProfile> AllIncluding(params Expression<Func<CustomerProfile, object>>[] includeProperties)
        {
            IQueryable<CustomerProfile> query = context.CustomerProfiles;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public CustomerProfile Find(int id)
        {
            return context.CustomerProfiles.Find(id);
        }

        public void InsertOrUpdate(CustomerProfile customerprofile)
        {
            if (customerprofile.CustomerProfileId == default(int)) {
                // New entity
                context.CustomerProfiles.Add(customerprofile);
            } else {
                // Existing entity
                context.Entry(customerprofile).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var customerprofile = context.CustomerProfiles.Find(id);
            context.CustomerProfiles.Remove(customerprofile);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ICustomerProfileRepository
    {
        IQueryable<CustomerProfile> All { get; }
        IQueryable<CustomerProfile> AllIncluding(params Expression<Func<CustomerProfile, object>>[] includeProperties);
        CustomerProfile Find(int id);
        void InsertOrUpdate(CustomerProfile customerprofile);
        void Delete(int id);
        void Save();
    }
}