using StuHub.Models.Stuhub;
using StuHub.Models.TotechsCloud;
using System;

namespace StuHub.Models
{
    public class UserModel : BaseEntity
    {
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileImageUrl { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime DayOfBirth { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string UserAddress { get; set; }
        public City UserCity { get; set; }
        public District UserDistrict { get; set; }
        public StudyGroup StudyGroup { get; set; }
        public StudyField StudyField { get; set; }
        public School School { get; set; }
    }
}
