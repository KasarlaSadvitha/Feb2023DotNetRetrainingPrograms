﻿using System.Web;
using System.Web.Mvc;

namespace WebApi2with__Tables
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}