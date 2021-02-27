using System;
using System.Collections.Generic;

namespace StuHub.Models.Stuhub
{
    public class Club
    {
        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public string ClubLogoURL { get; set; }
        public string ClubCoverImageURL { get; set; }
        public string Color { get; set; }
        public DateTime DateStarted { get; set; }
        public string Location { get; set; }
        public string PhoneNumbers { get; set; }
        public string Email { get; set; }
        public string ClubURL { get; set; }
        public string Intro { get; set; }
        public string Detail { get; set; }
        public int Rating { get; set; }
        public int Members { get; set; }
        public int Projects { get; set; }
        public string Requirement { get; set; }
        public int ClubPrice { get; set; }
    }
    public class DemoClubData
    {
        public static List<Club> GetData()
        {
            List<Club> data = new List<Club>();
            data.Add(new Club
            {
                ClubId = 1,
                ClubName = "IU UI/UX Club",
                ClubLogoURL = "ms-appx:///Assets/DemoAssets/SchoolLogos/IU.png",
                ClubCoverImageURL = "ms-appx:///Assets/DemoAssets/Club/UIUX.png",
                Color = "",
                DateStarted = new DateTime(2008, 5, 1, 8, 30, 52),
                Location = "Online",
                PhoneNumbers = "0348164682",
                Email = "FutureWingsStrypper@outlook.com",
                ClubURL = "",
                Intro = "Câu lạc bộ này để tụ tập các bạn đam mê lập trình công nghệ .NET, cùng nhau train và làm các dự án SE",
                Detail = "",
                Rating = 5,
                Members = 20,
                Projects = 5,
                Requirement = "Courage, Will and Fearless",
                ClubPrice = 21
            });
            data.Add(new Club
            {
                ClubId = 2,
                ClubName = "IU IoTClub",
                ClubLogoURL = "ms-appx:///Assets/DemoAssets/SchoolLogos/IU.png",
                ClubCoverImageURL = "ms-appx:///Assets/DemoAssets/Club/IOT.png",
                Color = "",
                DateStarted = new DateTime(2008, 5, 1, 8, 30, 52),
                Location = "Online",
                PhoneNumbers = "0348164682",
                Email = "ocgrb.strypperjason115@gmail.com",
                ClubURL = "",
                Intro = "Cậu lạc bộ về IOT làm các phần cứng bằng arduino và raspberry pi, kết nối mọi thứ bằng các protocol mạng mới",
                Detail = "",
                Rating = 4,
                Members = 12,
                Projects = 5,
                Requirement = "Courage, Will and Fearless",
                ClubPrice = 10
            });
            data.Add(new Club
            {
                ClubId = 3,
                ClubName = "IU Guitarclub",
                ClubLogoURL = "ms-appx:///Assets/DemoAssets/SchoolLogos/IU.png",
                ClubCoverImageURL = "ms-appx:///Assets/DemoAssets/Club/GUITAR.jpg",
                Color = "",
                DateStarted = new DateTime(2008, 5, 1, 8, 30, 52),
                Location = "Online",
                PhoneNumbers = "0348164682",
                Email = "chovameo@gmail.com",
                ClubURL = "",
                Intro = "Câu lạc bộ giúp hướng dẫn và rèn luyện các bạn ở IU, cùng nhau cất tiếng vang cho IU.",
                Detail = "",
                Rating = 3,
                Members = 112,
                Projects = 5,
                Requirement = "Courage, Will and Fearless",
                ClubPrice = 21
            });
            return data;
        }
    }
}
