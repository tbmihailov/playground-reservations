using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PlaygroundReservations.Models
{
    public enum ApprovalStatus
    {
        [Description("Одобрено")]
        Approved = 1,
        [Description("Отказано")]
        Rejected = 2
    }
}
