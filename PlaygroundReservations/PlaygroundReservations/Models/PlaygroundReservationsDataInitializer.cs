using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PlaygroundReservations.Models
{
    public class PlaygroundReservationsDataInitializer : DropCreateDatabaseAlways<PlaygroundReservationsContext>
	{
        protected override void Seed(PlaygroundReservationsContext context)
		{
            //context.Playgrounds.Add(new Playground());

			base.Seed(context);
		}
	}
}