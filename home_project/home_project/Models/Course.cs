namespace home_project.Models
{
    public class Course:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<CourseImages> CourseImages { get; set;}
    }
}
