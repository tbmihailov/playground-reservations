using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PlaygroundReservations.Models
{
    public enum PaymentType
    {
        [Description("Онлайн")]
        Online = 1,
        [Description("На място")]
        Offline = 2
    }
}