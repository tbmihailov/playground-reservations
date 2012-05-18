using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PlaygroundReservations.Models
{
    public partial class Playground
    {
        public int PlaygroundId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Width { get; set; }
        public double Length { get; set; }

        public int SurfaceId { get; set; }
        public virtual Surface Surface { get; set; }

        public int SportComplexId { get; set; }
        public virtual SportComplex SportComplex { get; set; }

        public virtual IEnumerable<PlaygroundImage> PlaygroundImages { get; set; }

        public virtual IEnumerable<Reservation> Reservations { get; set; }

        public virtual IEnumerable<ReservationFee> ReservationFees { get; set; }
    }
}
