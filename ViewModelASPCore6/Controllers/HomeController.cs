using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModelASPCore6.Models;

namespace ViewModelASPCore6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<StudentModel> students = new List<StudentModel> 
            {
                new StudentModel {Id = 1, Name ="A", Gender= "M", Age= 10},
                new StudentModel {Id = 2, Name ="B", Gender= "F", Age= 11},
                new StudentModel {Id = 3, Name ="C", Gender= "M", Age= 12},
                new StudentModel {Id = 4, Name ="D", Gender= "F", Age= 13}
            };

            List<TeacherModel> teachers = new List<TeacherModel>
            {
                new TeacherModel {Id = 11, Name ="E", Qualification= "M", Salary= 101},
                new TeacherModel {Id = 22, Name ="F", Qualification= "F", Salary= 102},
                new TeacherModel {Id = 33, Name ="G", Qualification= "M", Salary= 103},
                new TeacherModel {Id = 44, Name ="H", Qualification= "F", Salary= 104}
            };

            SchoolViewModel svm = new SchoolViewModel()
            {
                myStudents = students,
                myTeachers = teachers
            };
            return View(svm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}