﻿using Microsoft.AspNetCore.Mvc;

namespace DotNetCorePracticeApp.Controllers
{
    public class HomeController : Controller
    {
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


            ViewBag.data1 = "viewbag in c#";

            ViewBag.data2 = 22;
            
            string[] arr = { "Daniyal", "Ahmed", "22", "viewbagarr" };

            ViewBag.data3 = arr;

            ViewBag.data4 = new List<string>()
            {
                "Ahmed","Developer","21","viewbaglist"
            };

         //   ViewBag sy viewdata access krny k liye 
            ViewData["viewdataname"] = "Daniyal";




            return View();

        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}