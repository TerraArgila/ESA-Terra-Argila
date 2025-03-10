﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ESA_Terra_Argila.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            if (User.IsInRole("Vendor"))
            {
                return RedirectToRoute(new { controller = "Products", action = "Index" });
            }
            if (User.IsInRole("Supplier"))
            {
                return RedirectToRoute(new { controller = "Materials", action = "Index" });
            }
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
    }
}
