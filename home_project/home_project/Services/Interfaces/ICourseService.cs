using home_project.Models;

namespace home_project.Services.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllCourseAsync();
       
    }
    

}

