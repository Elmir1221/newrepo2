using home_project.Data;
using home_project.Services.Interfaces;
using home_project.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace home_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICourseService _courseServices;
        private readonly ICategoryService _categoryService;
        private readonly ICourseImagesServices _courseImagesServices;
        public HomeController(ICourseService courseServices, ICategoryService categoryService, ICourseImagesServices courseImagesServices )
        {
            _courseServices = courseServices;
            _categoryService = categoryService;
            _courseImagesServices = courseImagesServices;
        }
        public async Task< IActionResult > index()
        {
            HomeVM model = new()
            {
                Courses = await _courseServices.GetAllCourseAsync(),
                Categories =await _categoryService.GetAllCategoriesAsync(),
                CourseImages = await _courseImagesServices.GetAllCousreImageServices()
            };
            return View(model);
            
        }
    }
}