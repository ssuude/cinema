using System;

namespace SinemaCepte.Models
{
    public class Bilet
    {
        public string MovieTitle { get; set; }
        public DateTime ShowingDate { get; set; }
        public string Image { get; set; }

        public int[] Seats { get; set; }    
    }
}