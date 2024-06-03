namespace home_project.Models
{
    public class CourseImages
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
        public bool IsMain { get; set; }

        public string Image { get; set;}
        public Course Course { get; set; }

    }
}
