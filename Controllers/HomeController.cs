using DotNetCorePracticeApp.Model;
using DotNetCorePracticeApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace DotNetCorePracticeApp.Controllers
{
    public class HomeController : Controller



    {

        private readonly ILogger<HomeController> _logger;

        private readonly StudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        public List<StudentModel> getAllStudents(){
            return _studentRepository.getAllStudents();

        }

        public StudentModel getById(int id) {
        
        return _studentRepository.getStudentById(id);  
        
        
        }

        public IActionResult Index()
        {
            // View data view practice 

            //ViewData["data1"] = "Daniyal";


            //ViewData["data2"] = "22";

            //ViewData["data3"] = DateTime.Now.ToLongDateString();

            //string[] arr = {"Daniyal", "Ahmed","22","viewbagarr" };

            //ViewData["data4"] = arr;


            //ViewData["data5"] = new List<string>()
            //{
            //    "Ahmed","Developer","21" ,"viewbagList"
            //};


            // ViewBag.databag = "viewbag in c#";

            // View data view practice end


            //ViewBag ki practice start 

            //   ViewBag.data1 = "viewbag in c#";

            //   ViewBag.data2 = 22;

            //   string[] arr = { "Daniyal", "Ahmed", "22", "viewbagarr" };

            //   ViewBag.data3 = arr;

            //   ViewBag.data4 = new List<string>()
            //   {
            //       "Ahmed","Developer","21","viewbaglist"
            //   };

            ////   ViewBag sy viewdata access krny k liye 
            //   ViewData["viewdataname"] = "Daniyal";



            //ViewBag ki practice end 


            //tempData practice start

            //TempData["data3"] = "temp data ";
            //TempData["tem"] = "tempdata about";
            //TempData.Keep();
            //TempData["templist"] = new List<string>()
            //    {

            //             "Ahmed","Developer","21","viewbaglist"

            //    };


            //ye m ny model class ki video k liye use kiya tha 

            var student = new List<StudentModel>
            {
                new StudentModel {rollNo = 1 , Name = "Daniyal", Stand=12},
                new StudentModel {rollNo = 2 , Name = "Ahmed", Stand=11},
                new StudentModel {rollNo = 3 , Name = "Ali", Stand=10},
            };

         //   ViewData["myStudent"] = student;
            return View(student);

        }

        public IActionResult About()
        {
            //TempData["data3"] = "temp data ";


            //TempData.Keep("tem"); var student = new List<StudentModel>
            var student = new List<StudentModel>
            {
                new StudentModel {rollNo = 1 , Name = "Daniyal", Stand=12},
                new StudentModel {rollNo = 2 , Name = "Ahmed", Stand=11},
                new StudentModel {rollNo = 3 , Name = "Ali", Stand=10},
            };

            //   ViewData["myStudent"] = student;
            return View(student);
        }

        public IActionResult Contact()
        {
            //TempData.Keep("tem");
            return View();
        }
    }
}
