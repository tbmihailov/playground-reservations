using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PlaygroundReservations.Models
{
    public enum UserType
    {
        [Description("Собственик на игрище")]
        Owner = 2,
        [Description("Обикновен потребител")]
        Customer = 1,
        
    }
}