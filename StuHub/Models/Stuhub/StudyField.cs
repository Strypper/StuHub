using System;

namespace StuHub.Models.Stuhub
{
    public class StudyField
    {
        public string StudyFieldId { get; set; }
        public string StudyFieldName { get; set; } = String.Empty;
        public CollegeGroup CollegeGroup { get; set; }
    }
}
