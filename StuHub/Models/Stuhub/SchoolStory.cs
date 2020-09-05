using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuHub.Models.Stuhub
{
    public class SchoolStory
    {
        public int SchoolStoryId { get; set; }
        public string SchoolId { get; set; }
        public string StudentId { get; set; }
        public string StudentImageProfileUrl { get; set; }
        public string StudentName { get; set; }
        public string SchoolName { get; set; }
        public DateTime UploadDate { get; set; }
        public string Story { get; set; }
        public string Feeling { get; set; }
        public string StoryImageUrl { get; set; }
        public int Like { get; set; }
    }
}
