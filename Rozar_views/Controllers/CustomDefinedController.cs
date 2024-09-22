using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Controllers_And_ActionMethod.Controllers
{
    public class CustomDefinedController : Controller
    {
        public IActionResult Index()
        {
            // IActionResult can return many types of data

            return View(); // Returns a View
        }

        // Define the action method with correct access modifier and syntax
        public string Display()
        {
            return "Welcome to .NET Core";
        }

        // Another action method with an int parameter
        public int DisplayId(int id)
        {
            return id;
        }


        // return types which actionResult and IactionResult holds

        // jsonResult action method
        public JsonResult akash()
        {
            var first_name = "akash mishra";
            //var second_name = "adarsh upadhyay";

            return Json(new
            {
                data = first_name,

                //data = second_name,
            }); 


        }


        // it returns the data in the form of json data

        // contentResult 

        public ContentResult adarsh()
        {
            return Content("my name is adarsh upadhyay ");
        }

        // this is returs the data in the form of the vontent resut


        //  partialViewResult 

        public PartialViewResult vishal()
        {
            return PartialView("~/Views/CustomDefined/_Index1.cshtml");
        }

        // this returns a partial view

        //Viewresult

        public ViewResult view()
        {
            return View("~/Views/CustomDefined/Index.cshtml");
        }

        // it returns a simple view


        // emptyResult

        public EmptyResult EmptyResult()
        {
            return new EmptyResult();
        }

    }
}
