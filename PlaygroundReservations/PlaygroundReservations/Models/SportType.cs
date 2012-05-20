using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PlaygroundReservations.Models
{
    public enum SportType
    {
        [Description("Футбол")]
        Football = 1,
        [Description("Тенис")]
        Tennis = 2
    }
}