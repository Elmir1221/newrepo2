using home_project.Data;
using home_project.Models;
using home_project.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace home_project.Services
{
    public class CourseService : ICourseService
    {
        private readonly AppDbContext _Context;

        public CourseService( AppDbContext Context)
        {
            _Context = Context; 
        }
        public async Task<IEnumerable<Course>> GetAllCourseAsync()
        {
            return await _Context.Courses.Where(m => !m.SoftDeleted).ToListAsync();
        }
    }
}
