using home_project.Data;
using home_project.Models;
using home_project.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace home_project.Services
{
    public class CourseImagesService : ICourseImagesServices
    {
        private readonly AppDbContext _appDb;

        public CourseImagesService(AppDbContext appDb)
        {
            _appDb = appDb;
        }

        public async Task<IEnumerable<CourseImages>> GetAllCousreImageServices()
        {
            return await _appDb.CourseImages.Where(m => m.IsMain).ToListAsync();
        }
    }
}
