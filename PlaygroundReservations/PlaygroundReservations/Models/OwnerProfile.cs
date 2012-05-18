using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaygroundReservations.Models
{
    public partial class OwnerProfile
    {
        public int OwnerProfileId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string LiablePersonName { get; set; }
        public string Notes { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }

        public virtual IEnumerable<SportComplex> SportComplexes { get; set; }
    }
}