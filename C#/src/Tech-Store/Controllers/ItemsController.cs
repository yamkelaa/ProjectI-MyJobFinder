using Microsoft.AspNetCore.Mvc;
using Tech_Store.Models;

namespace Tech_Store.Controllers
{
    public class ItemsController : Controller
    {
        //IActionResult defines what the user can return
        //It can be a viewresult that would return view without any arguments
        //We counld return a content or json result
        public IActionResult Overview()
        {
            var item = new Item() { Name = "Keyboard" };
            return View(item);
        }

        //Query strings are used to sort or filter data
        //Its set in the program.cs therefore the name should be id otherwise use a query param 
        public IActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
    }
}
