using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PlaygroundReservations.Models
{
    public class PlaygroundReservationsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<PlaygroundReservations.Models.PlaygroundReservationsContext>());

        public DbSet<PlaygroundReservations.Models.SportComplex> SportComplexes { get; set; }

        public DbSet<PlaygroundReservations.Models.CustomerProfile> CustomerProfiles { get; set; }

        public DbSet<PlaygroundReservations.Models.OwnerProfile> OwnerProfiles { get; set; }

        public DbSet<PlaygroundReservations.Models.Surface> Surfaces { get; set; }

        public DbSet<PlaygroundReservations.Models.Playground> Playgrounds { get; set; }

        public DbSet<PlaygroundReservations.Models.PlaygroundImage> PlaygroundImages { get; set; }

        public DbSet<PlaygroundReservations.Models.Reservation> Reservations { get; set; }

        public DbSet<PlaygroundReservations.Models.ReservationFee> ReservationFees { get; set; }
    }
}