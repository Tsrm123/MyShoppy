using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WecareMVC.Models
{
    public class Artist
    {
        [DisplayName("ArtistID")]
        public int ArtistId { get; set; }
        [DisplayName("Artist名稱")]
        public string Name { get; set; }
    }
}