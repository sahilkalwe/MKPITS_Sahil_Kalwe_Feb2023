using Fendahl1ProjectMVC.Controllers;
using Fendahl1ProjectMVC.Models;
using Fendahl1ProjectMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fendahl1ProjectMVC.Controllers
{

    public class HomeController : Controller
    {
        private readonly fendyl_pprojectbEntities fpe;
        public HomeController()
        {
            fpe = new fendyl_pprojectbEntities();
        }
        // GET: Home
        public ActionResult Index()
        {
            var objCategoryRepository = new CategoryRepositories();
            var ObjProductCategory = new ProductRepository();
            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>( objCategoryRepository.GetAllCategories(),ObjProductCategory.GetAllProducts());

            return View(objMultipleModels);
        }

            [HttpGet]
            
            public JsonResult getAllProducts(int catid)
            {

                fpe.Configuration.ProxyCreationEnabled = false;
                List<TableProduct> ProductList = fpe.TableProducts.Where(x => x.ProductTypeID == catid).ToList();
                return Json(ProductList, JsonRequestBehavior.AllowGet);
            }
            


        
    }
}
