using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingBerretDecaillet.Models
{
    public class Picture
    {
        [Key]
        public int IdPicture { get; set; }
        public string Url { get; set; }
        public Room Room { get; set; }

        public override string ToString()
        {
            return "idPicture : " + IdPicture +
                "url : " + Url +
                " room : " + Room;
        }
    }
}