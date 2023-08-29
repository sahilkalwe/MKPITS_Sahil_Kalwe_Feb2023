using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fendahl1ProjectMVC.Controllers;
using Fendahl1ProjectMVC.Models;
using Fendahl1ProjectMVC.Repositories;

namespace Fendahl1ProjectMVC.ViewModel
{
    public class ProductViewModel
    {
        private int Product_ID { get; set; }

        private int ProductTypeID { get; set; }

        private int Peroduct_Name{ get; set; }

        private int Price{ get; set; }
    }
}