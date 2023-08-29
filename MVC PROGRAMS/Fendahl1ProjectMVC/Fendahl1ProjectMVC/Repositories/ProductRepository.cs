using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fendahl1ProjectMVC.Models;
using Fendahl1ProjectMVC.Repositories;
using Fendahl1ProjectMVC.ViewModel;

namespace Fendahl1ProjectMVC.Repositories
{
    public class ProductRepository
    {
        private readonly fendyl_pprojectbEntities fpe;
        public ProductRepository()
        {
            fpe = new fendyl_pprojectbEntities();
        }
        public IEnumerable<SelectListItem> GetAllProducts()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in fpe.TableProducts
                                    select new SelectListItem
                                    {
                                        Text = obj.ProductName,
                                        Value = obj.ProductID.ToString(),
                                        Selected = true
                                    }
                                ).ToList();


            return objSelectListItems;
        }
    }
}