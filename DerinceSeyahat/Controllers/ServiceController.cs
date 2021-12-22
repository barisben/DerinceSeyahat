using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerinceSeyahat.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult PersonelTasimaciligi()
        {
            return View();
        }
        public IActionResult OgrenciTasimaciligi()
        {
            return View();
        }
        public IActionResult VipTasimaciligi()
        {
            return View();
        }
        public IActionResult OrganizasyonTasimaciligi()
        {
            return View();
        }
        public IActionResult OzelGunTasimaciligi()
        {
            return View();
        }
    }
}
