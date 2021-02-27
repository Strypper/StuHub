using System;

namespace StuHub.Models.TotechsCloud
{
    public class Location
    {
        public string LocationId { get; set; }
        public City City { get; set; }
        public District District { get; set; }
        public string Address { get; set; } = String.Empty;
    }
}
