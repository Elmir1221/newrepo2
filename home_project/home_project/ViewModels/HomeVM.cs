using home_project.Models;

namespace home_project.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<CourseImages> CourseImages { get; set; }



    }
}
