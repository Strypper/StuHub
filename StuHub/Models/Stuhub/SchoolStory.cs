using System;
using System.Collections.ObjectModel;

namespace StuHub.Models.Stuhub
{
    public class SchoolStory
    {
        public string SchoolStoryId { get; set; }
        public School School { get; set; }
        public Student Student { get; set; }
        public DateTime UploadDate { get; set; }
        public string Story { get; set; }
        public string Feeling { get; set; }
        public string StoryImageUrl { get; set; }
        public int Like { get; set; }
    }

    public class DemoSchoolStoryData
    {
        public static ObservableCollection<SchoolStory> GetData()
        {
            var data = new ObservableCollection<SchoolStory>();
            //DemoSchoolData
            var sc1 = new School() { SchoolID = "SC1", SchoolLogoUrl = "ms-appx:///Assets/DemoAssets/SchoolLogos/BK.png", SchoolName = "Trường đại học Bách Khoa", MalePercentage = 70f, FemalePercentage = 30f };
            var sc2 = new School() { SchoolID = "SC2", SchoolLogoUrl = "ms-appx:///Assets/DemoAssets/SchoolLogos/BUH.jpg", SchoolName = "Trường đại học Ngân Hàng", MalePercentage = 20f, FemalePercentage = 80f };
            var sc3 = new School() { SchoolID = "SC3", SchoolLogoUrl = "ms-appx:///Assets/DemoAssets/SchoolLogos/IU.png", SchoolName = "Trường đại học Quốc Tế", MalePercentage = 20f, FemalePercentage = 80f };
            var sc4 = new School() { SchoolID = "SC4", SchoolLogoUrl = "ms-appx:///Assets/DemoAssets/SchoolLogos/KHTN.png", SchoolName = "Trường đại học Khoa Học Tự Nhiên", MalePercentage = 20f, FemalePercentage = 80f };
            var sc5 = new School() { SchoolID = "SC5", SchoolLogoUrl = "ms-appx:///Assets/DemoAssets/SchoolLogos/UIT.png", SchoolName = "Trường đại học Khoa Công Nghê Thông Tin", MalePercentage = 20f, FemalePercentage = 80f };
            //DemoStudentData
            var student1 = new Student() {StudentId = "STU1", StudentName = "Strypper Vandel Jason", ProfilePictureUrl = "ms-appx:///Assets/DemoAssets/ProfileImage/Me(ver 2019).jpg", Age = 25, Gender = true, School = sc3, SchoolIdCard = "ITITIU14109" };
            var student2 = new Student() { StudentId = "STU2", StudentName = "Huỳnh Quốc Gia", ProfilePictureUrl = "ms-appx:///Assets/DemoAssets/ProfileImage/Gia.jpg", Age = 25, Gender = true, School = sc3, SchoolIdCard = "LEISIU14109" };
            var student3 = new Student() { StudentId = "STU3", StudentName = "Dương Mai Hoàng", ProfilePictureUrl = "ms-appx:///Assets/DemoAssets/ProfileImage/Hoàng.jpg", Age = 22, Gender = true, School = sc3, SchoolIdCard = "ITITIU18109" };
            var student4 = new Student() { StudentId = "STU4", StudentName = "Đỗ Văn Hưng", ProfilePictureUrl = "ms-appx:///Assets/DemoAssets/ProfileImage/Hưng.jpg", Age = 22, Gender = true, School = sc3, SchoolIdCard = "ITITIU18109" };
            var student5 = new Student() { StudentId = "STU5", StudentName = "Nguyễn Kim Phát", ProfilePictureUrl = "ms-appx:///Assets/DemoAssets/ProfileImage/Phát.jpg", Age = 25, Gender = true, School = sc3, SchoolIdCard = "ITITIU14219" };
            var student6 = new Student() { StudentId = "STU6", StudentName = "Đỗ Nam Trung", ProfilePictureUrl = "ms-appx:///Assets/DemoAssets/ProfileImage/Trung.jpg", Age = 25, Gender = true, School = sc3, SchoolIdCard = "ITITIU14123" };
            data.Add(new SchoolStory
            {
                SchoolStoryId = "Story1",
                Student = student1,
                School = sc3,
                Story = "Lên đại học thì học đại cho nó lẹ 👌",
                Feeling = "Great",
                StoryImageUrl = "ms-appx:///Assets/DemoAssets/SchoolStory/IUTest1.jpg",
                Like = 1290
            });
            data.Add(new SchoolStory
            {
                SchoolStoryId = "Story2",
                Student = student2,
                School = sc3,
                Story = "Vướng chuyện tình trường, mai lên công an viết tường trình 🙂",
                Feeling = "Sad",
                StoryImageUrl = "ms-appx:///Assets/DemoAssets/SchoolStory/IUTest2.jpg",
                Like = 350
            });
            data.Add(new SchoolStory
            {
                SchoolStoryId = "Story3",
                Student = student3,
                School = sc3,
                Story = "Tình yêu không tương thích, Thì chỉ mang lại thương tích 💔",
                Feeling = "Great",
                StoryImageUrl = "ms-appx:///Assets/DemoAssets/SchoolStory/IUTest3.jpg",
                Like = 290
            });
            data.Add(new SchoolStory
            {
                SchoolStoryId = "Story4",
                Student = student4,
                School = sc3,
                Story = "Nhớ em, tìm nơi đâu ? vì em luôn đứng đầu nơi tim 🥰",
                Feeling = "Great",
                StoryImageUrl = "ms-appx:///Assets/DemoAssets/SchoolStory/IUTest4.jpg",
                Like = 1320
            });
            data.Add(new SchoolStory
            {
                SchoolStoryId = "Story5",
                Student = student5,
                School = sc3,
                Story = "Lên đại học thì học đại cho nó lẹ 👌",
                Feeling = "Great",
                StoryImageUrl = "ms-appx:///Assets/DemoAssets/SchoolStory/IUTest5.jpg",
                Like = 1001
            });
            data.Add(new SchoolStory
            {
                SchoolStoryId = "Story6",
                Student = student6,
                School = sc3,
                Story = "Lên đại học thì học đại cho nó lẹ 👌",
                Feeling = "Great",
                StoryImageUrl = "ms-appx:///Assets/DemoAssets/SchoolStory/IUTest6.jpg",
                Like = 200
            });
            return data;
        }
    }
}
