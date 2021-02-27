using System;

namespace StuHub.Models.TotechsCloud
{
    public class District
    {
        public string DistrictId { get; set; }
        public string DistrictName { get; set; } = String.Empty;
        public City City { get; set; }
    }
}
