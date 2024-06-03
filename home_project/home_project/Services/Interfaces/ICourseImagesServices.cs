using home_project.Models;

namespace home_project.Services.Interfaces
{
    public interface ICourseImagesServices
    {
        Task<IEnumerable<CourseImages>> GetAllCousreImageServices();
    }
}
