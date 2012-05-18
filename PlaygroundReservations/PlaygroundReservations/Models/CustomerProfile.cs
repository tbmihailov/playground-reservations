using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaygroundReservations.Models
{
    public partial class CustomerProfile
    {
        public int CustomerProfileId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string Phone { get; set; }

        public virtual IEnumerable<Reservation> Reservations { get; set; }
    }
}