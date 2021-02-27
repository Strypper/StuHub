using StuHub.Models.TotechsCloud;
using System;
using System.Collections.ObjectModel;

namespace StuHub.Models.Stuhub
{
    public class SubjectRequest : BaseEntity
    {
        public string SubjectRequestId { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public decimal? Price { get; set; }
        public Subject Subject { get; set; }
        public DateTime RequestDate { get; set; }
        public Location Location { get; set; }
        public Student Requester { get; set; }
    }

    public class CollegeSubjectRequest : SubjectRequest
    {
        public CollegeSubject CollegeSubject { get; set; }
        public DateTime DateUpload { get; set; }
        public decimal Price { get; set; }
        public string Teacher { get; set; }
        public bool HomeWork { get; set; }
        public bool Presentation { get; set; }
        public bool Laboratory { get; set; }
        public City LearningCity { get; set; }
        public District LearningDistrict { get; set; }
        public UserModel Owner { get; set; }
        public PaymentTimeType PaymentTimeType { get; set; }
    }

    public enum PaymentTimeType
    {
        Hour = 0,
        Day = 1,
        Week = 2,
        Month = 3,
        Custom = 4
    }


    //DEMO DATA
    public class DemoCollegeSubjectRequestData
    {
        public static ObservableCollection<CollegeSubjectRequest> GetData()
        {
            var data = new ObservableCollection<CollegeSubjectRequest>();
            var school = new School() { SchoolID = "SC1", SchoolLogoUrl = "ms-appx:///Assets/DemoAssets/SchoolLogos/BK.png", SchoolName = "Trường đại học Bách Khoa", MalePercentage = 70f, FemalePercentage = 30f };
            var cs = new CollegeSubject() { Id = 0, SubjectName = "Mac Lenin", School = school};
            var sj = new CollegeSubjectRequest() { Id = 0, Description = "Cần người dạy môn Mac Lenin vào chiều thứ 6-7, bao nước luôn.", RequestDate = DateTime.Now, Price = 300, PaymentTimeType = PaymentTimeType.Day,
                                                   CollegeSubject = cs};
            data.Add(sj);
            return data;
        }
    }
}
