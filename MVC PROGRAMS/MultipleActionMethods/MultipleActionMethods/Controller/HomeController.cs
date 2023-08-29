using Microsoft.AspNetCore.Mvc;

namespace MultipleActionMethods.Controller
{
   public class HomeController
    {
        [Route("Home")]
        public string Index()
        {
            return "Hello from index";
        }


        [Route("About")]
        public string About()
        {
            return "Hello from About";
        }


        [Route("Contact/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "Hello from Contact";
        }
    }
}
