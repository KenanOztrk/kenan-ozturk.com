using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KenanOzturk.Controllers
{
    public class IletisimController : Controller
    {
        public IActionResult Iletisim()
        {
            return View();
        }
    }
}
