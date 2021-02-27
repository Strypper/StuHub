using StuHub.Models.TotechsCloud;
using System;

namespace StuHub.Models.Stuhub
{
    public class Student
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; } = String.Empty;
        public string ProfilePictureUrl { get; set; } = String.Empty;
        public School School { get; set; }
        public string SchoolIdCard { get; set; } = String.Empty;
        public DateTime BirthDay { get; set; }
        public int? Age { get; set; }
        public bool Gender { get; set; }
        public Location Location { get; set; }
    }
}
