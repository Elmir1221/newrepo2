using home_project.Data;
using home_project.Models;
using home_project.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace home_project.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _dbContext;

        public CategoryService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _dbContext.Categories.Where(m => !m.SoftDeleted).ToListAsync();
           
        }
    }
}
