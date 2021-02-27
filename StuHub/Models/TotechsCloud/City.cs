using System.Collections.Generic;

namespace StuHub.Models.TotechsCloud
{
    public class City
    {
        public string CityId { get; set; }
        public string CityName { get; set; }
        public ICollection<District> Districts { get; set; }
    }
}
