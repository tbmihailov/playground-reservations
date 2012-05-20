using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace PlaygroundReservations.Models
{ 
    public class SportComplexRepository : ISportComplexRepository
    {
        PlaygroundReservationsContext context;// = new PlaygroundReservationsContext();

		//If you are using Dependency Injection, you can delete the following constructor
		public SportComplexRepository()
			:this(new PlaygroundReservationsContext())
		{}

		public SportComplexRepository(PlaygroundReservationsContext context)
		{
			this.context = context;
		}

        public IQueryable<SportComplex> All
        {
            get { return context.SportComplexes; }
        }

        public IQueryable<SportComplex> AllIncluding(params Expression<Func<SportComplex, object>>[] includeProperties)
        {
            IQueryable<SportComplex> query = context.SportComplexes;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public SportComplex Find(int id)
        {
            return context.SportComplexes.Find(id);
        }

        public void InsertOrUpdate(SportComplex sportcomplex)
        {
            if (sportcomplex.SportComplexId == default(int)) {
                // New entity
                context.SportComplexes.Add(sportcomplex);
            } else {
                // Existing entity
                context.Entry(sportcomplex).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var sportcomplex = context.SportComplexes.Find(id);
            context.SportComplexes.Remove(sportcomplex);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISportComplexRepository
    {
        IQueryable<SportComplex> All { get; }
        IQueryable<SportComplex> AllIncluding(params Expression<Func<SportComplex, object>>[] includeProperties);
        SportComplex Find(int id);
        void InsertOrUpdate(SportComplex sportcomplex);
        void Delete(int id);
        void Save();
    }
}