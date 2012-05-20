using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PlaygroundReservations.Models
{
    public enum ReservationType
    {
        [Description("Онлайн")]
        Online = 1,
        [Description("По телефона или на място")]
        Offline = 2
    }
}
