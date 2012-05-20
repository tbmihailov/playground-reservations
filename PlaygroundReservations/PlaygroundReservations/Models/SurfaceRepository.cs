using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace PlaygroundReservations.Models
{ 
    public class SurfaceRepository : ISurfaceRepository
    {
        PlaygroundReservationsContext context;// = new PlaygroundReservationsContext();

		//If you are using Dependency Injection, you can delete the following constructor
		public SurfaceRepository()
			:this(new PlaygroundReservationsContext())
		{}

		public SurfaceRepository(PlaygroundReservationsContext context)
		{
			this.context = context;
		}

        public IQueryable<Surface> All
        {
            get { return context.Surfaces; }
        }

        public IQueryable<Surface> AllIncluding(params Expression<Func<Surface, object>>[] includeProperties)
        {
            IQueryable<Surface> query = context.Surfaces;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Surface Find(int id)
        {
            return context.Surfaces.Find(id);
        }

        public void InsertOrUpdate(Surface surface)
        {
            if (surface.SurfaceId == default(int)) {
                // New entity
                context.Surfaces.Add(surface);
            } else {
                // Existing entity
                context.Entry(surface).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var surface = context.Surfaces.Find(id);
            context.Surfaces.Remove(surface);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISurfaceRepository
    {
        IQueryable<Surface> All { get; }
        IQueryable<Surface> AllIncluding(params Expression<Func<Surface, object>>[] includeProperties);
        Surface Find(int id);
        void InsertOrUpdate(Surface surface);
        void Delete(int id);
        void Save();
    }
}