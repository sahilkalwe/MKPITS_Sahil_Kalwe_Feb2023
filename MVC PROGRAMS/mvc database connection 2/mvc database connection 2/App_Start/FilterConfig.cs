﻿using System.Web;
using System.Web.Mvc;

namespace mvc_database_connection_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
