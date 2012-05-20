using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace PlaygroundReservations.Models
{ 
    public class OwnerProfileRepository : IOwnerProfileRepository
    {
        PlaygroundReservationsContext context;// = new PlaygroundReservationsContext();

		//If you are using Dependency Injection, you can delete the following constructor
		public OwnerProfileRepository()
			:this(new PlaygroundReservationsContext())
		{}

		public OwnerProfileRepository(PlaygroundReservationsContext context)
		{
			this.context = context;
		}

        public IQueryable<OwnerProfile> All
        {
            get { return context.OwnerProfiles; }
        }

        public IQueryable<OwnerProfile> AllIncluding(params Expression<Func<OwnerProfile, object>>[] includeProperties)
        {
            IQueryable<OwnerProfile> query = context.OwnerProfiles;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public OwnerProfile Find(int id)
        {
            return context.OwnerProfiles.Find(id);
        }

        public void InsertOrUpdate(OwnerProfile ownerprofile)
        {
            if (ownerprofile.OwnerProfileId == default(int)) {
                // New entity
                context.OwnerProfiles.Add(ownerprofile);
            } else {
                // Existing entity
                context.Entry(ownerprofile).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var ownerprofile = context.OwnerProfiles.Find(id);
            context.OwnerProfiles.Remove(ownerprofile);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOwnerProfileRepository
    {
        IQueryable<OwnerProfile> All { get; }
        IQueryable<OwnerProfile> AllIncluding(params Expression<Func<OwnerProfile, object>>[] includeProperties);
        OwnerProfile Find(int id);
        void InsertOrUpdate(OwnerProfile ownerprofile);
        void Delete(int id);
        void Save();
    }
}