using System;

namespace StuHub.Models.Stuhub
{
    public class Subject : BaseEntity
    {
        public string SubjectName { get; set; } = String.Empty;
        public School School { get; set; }
    }
}
