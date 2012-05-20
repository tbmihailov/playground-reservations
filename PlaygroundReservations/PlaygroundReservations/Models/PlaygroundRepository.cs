using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace PlaygroundReservations.Models
{ 
    public class PlaygroundRepository : IPlaygroundRepository
    {
        PlaygroundReservationsContext context;// = new PlaygroundReservationsContext();

		//If you are using Dependency Injection, you can delete the following constructor
		public PlaygroundRepository()
			:this(new PlaygroundReservationsContext())
		{}

		public PlaygroundRepository(PlaygroundReservationsContext context)
		{
			this.context = context;
		}

        public IQueryable<Playground> All
        {
            get { return context.Playgrounds; }
        }

        public IQueryable<Playground> AllIncluding(params Expression<Func<Playground, object>>[] includeProperties)
        {
            IQueryable<Playground> query = context.Playgrounds;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Playground Find(int id)
        {
            return context.Playgrounds.Find(id);
        }

        public void InsertOrUpdate(Playground playground)
        {
            if (playground.PlaygroundId == default(int)) {
                // New entity
                context.Playgrounds.Add(playground);
            } else {
                // Existing entity
                context.Entry(playground).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var playground = context.Playgrounds.Find(id);
            context.Playgrounds.Remove(playground);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IPlaygroundRepository
    {
        IQueryable<Playground> All { get; }
        IQueryable<Playground> AllIncluding(params Expression<Func<Playground, object>>[] includeProperties);
        Playground Find(int id);
        void InsertOrUpdate(Playground playground);
        void Delete(int id);
        void Save();
    }
}