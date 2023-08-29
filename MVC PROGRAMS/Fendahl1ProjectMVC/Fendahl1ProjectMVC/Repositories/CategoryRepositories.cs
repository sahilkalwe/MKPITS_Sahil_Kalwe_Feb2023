using Fendahl1ProjectMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Fendahl1ProjectMVC.Repositories
{
    public class CategoryRepositories
    {
        private readonly fendyl_pprojectbEntities fpe;
        public CategoryRepositories()
        {
            fpe = new fendyl_pprojectbEntities();
        }

        public IEnumerable<SelectListItem> GetAllCategories()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (
                                   from obj in fpe.TableProductCategories
                                   select new SelectListItem
                                   {
                                       Text = obj.Product_Type_Name,
                                       Value = obj.Product_Category_ID.ToString(),
                                       Selected = true
                                   }
                               ).ToList();
            return objSelectListItems;

        }
    }
}