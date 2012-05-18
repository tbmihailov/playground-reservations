using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaygroundReservations.Models
{
    public partial class PlaygroundImage
    {
        public int PlaygroundImageId { get; set; }
        public string Path { get; set; }

        public int PlaygroundId { get; set; }
        public virtual Playground Playground { get; set; }
    }
}