using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaygroundReservations.Models
{
    public partial class SportComplex
    {
        public int SportComplexId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Section { get; set; }
        public string Description { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        //gps coordinates
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public int OwnerId { get; set; }
        public virtual OwnerProfile Owner { get; set; }

        public virtual IEnumerable<Playground> Playgrounds { get; set; }
    }
}