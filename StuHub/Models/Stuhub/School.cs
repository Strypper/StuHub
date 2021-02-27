using StuHub.Models.TotechsCloud;
using System;
using System.Collections.Generic;

namespace StuHub.Models.Stuhub
{
    public class School
    {
        public string SchoolID { get; set; } = String.Empty;
        public string SchoolLogoUrl { get; set; } = String.Empty;
        public string SchoolName { get; set; } = String.Empty;
        public float MalePercentage { get; set; }
        public float FemalePercentage { get; set; }
        //public Location? Location { get; set; }
    }

    public class DemoSchoolData 
    {
        public static List<School> GetData()
        {
            var data = new List<School>();
            data.Add(new School() { SchoolID = "SC1", SchoolLogoUrl = "ms-appx:///Assets/DemoAssets/SchoolLogos/BK.png", SchoolName = "Trường đại học Bách Khoa", MalePercentage = 70f, FemalePercentage = 30f });
            data.Add(new School() { SchoolID = "SC2", SchoolLogoUrl = "ms-appx:///Assets/DemoAssets/SchoolLogos/BUH.jpg", SchoolName = "Trường đại học Ngân Hàng", MalePercentage = 20f, FemalePercentage = 80f });
            data.Add(new School() { SchoolID = "SC3", SchoolLogoUrl = "ms-appx:///Assets/DemoAssets/SchoolLogos/IU.png", SchoolName = "Trường đại học Quốc Tế", MalePercentage = 55f, FemalePercentage = 45f });
            data.Add(new School() { SchoolID = "SC4", SchoolLogoUrl = "ms-appx:///Assets/DemoAssets/SchoolLogos/KHTN.png", SchoolName = "Trường đại học Khoa Học Tự Nhiên", MalePercentage = 65f, FemalePercentage = 35f });
            data.Add(new School() { SchoolID = "SC5", SchoolLogoUrl = "ms-appx:///Assets/DemoAssets/SchoolLogos/UIT.png", SchoolName = "Trường đại học Công Nghệ Thông Tin", MalePercentage = 90f, FemalePercentage = 10f });
            data.Add(new School() { SchoolID = "SC6", SchoolLogoUrl = "ms-appx:///Assets/DemoAssets/SchoolLogos/BUH.jpg", SchoolName = "Trường đại học Ngân Hàng", MalePercentage = 20f, FemalePercentage = 80f });
            return data;
        }
    }
}
