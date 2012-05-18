using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaygroundReservations.Models
{
    public class ReservationFee
    {
        public int ReservationFeeId { get; set; }

        public int PlaygroundId { get; set; }
        public virtual Playground Playground { get; set; }

        public int DayOfWeek { get; set; }
        public int TimeFrom { get; set; }
        public int TimeTo { get; set; }
        public decimal Price { get; set; }
    }
}