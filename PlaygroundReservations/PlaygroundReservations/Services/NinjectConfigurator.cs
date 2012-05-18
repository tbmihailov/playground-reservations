using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bootstrap.Ninject;
using PlaygroundReservations.Models;
using System.Data.Entity;

namespace PlaygroundReservations.Services
{
    public class NinjectConfigurator : INinjectRegistration
    {
        public void Register(Ninject.IKernel container)
        {
            //database initializer
            //container.Bind<IDatabaseInitializer<ThipperContext>>().To<ThipperSampleDataInitializer>();
            //container.Bind<ThipperContext>().To<ThipperContext>().InRequestScope();
            
            //repositories
            //container.Bind<IUserProfileRepository>().To<UserProfileRepository>();
            //container.Bind<IObjectDetailRepository>().To<ObjectDetailRepository>();
            //container.Bind<IItemRepository>().To<ItemRepository>();
            //container.Bind<ILocationRepository>().To<LocationRepository>();
            //container.Bind<IContactRepository>().To<ContactRepository>();
            //container.Bind<IGroupRepository>().To<GroupRepository>();
            //container.Bind<ITrackRepository>().To<TrackRepository>();
        }

    }
}