using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace PlaygroundReservations.Models
{ 
    public class PlaygroundImageRepository : IPlaygroundImageRepository
    {
        PlaygroundReservationsContext context;// = new PlaygroundReservationsContext();

		//If you are using Dependency Injection, you can delete the following constructor
		public PlaygroundImageRepository()
			:this(new PlaygroundReservationsContext())
		{}

		public PlaygroundImageRepository(PlaygroundReservationsContext context)
		{
			this.context = context;
		}

        public IQueryable<PlaygroundImage> All
        {
            get { return context.PlaygroundImages; }
        }

        public IQueryable<PlaygroundImage> AllIncluding(params Expression<Func<PlaygroundImage, object>>[] includeProperties)
        {
            IQueryable<PlaygroundImage> query = context.PlaygroundImages;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public PlaygroundImage Find(int id)
        {
            return context.PlaygroundImages.Find(id);
        }

        public void InsertOrUpdate(PlaygroundImage playgroundimage)
        {
            if (playgroundimage.PlaygroundImageId == default(int)) {
                // New entity
                context.PlaygroundImages.Add(playgroundimage);
            } else {
                // Existing entity
                context.Entry(playgroundimage).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var playgroundimage = context.PlaygroundImages.Find(id);
            context.PlaygroundImages.Remove(playgroundimage);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IPlaygroundImageRepository
    {
        IQueryable<PlaygroundImage> All { get; }
        IQueryable<PlaygroundImage> AllIncluding(params Expression<Func<PlaygroundImage, object>>[] includeProperties);
        PlaygroundImage Find(int id);
        void InsertOrUpdate(PlaygroundImage playgroundimage);
        void Delete(int id);
        void Save();
    }
}