using Microsoft.AspNetCore.Mvc;
using System.Net.Security;

namespace ControllerOnly.Controller
{
   public class Homecontroller
    {
        [Route("bhadya")]
        public string method1()
            {
            return "Hello from Jayesh & trupti";
            }
    }
}
