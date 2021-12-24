using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerinceSeyahat.Controllers
{
    public class FiloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
