﻿using System.Web;
using System.Web.Mvc;

namespace WebApplication1_mvs_database
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
