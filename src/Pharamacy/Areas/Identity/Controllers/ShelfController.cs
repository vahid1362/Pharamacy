using DNTBreadCrumb.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Pharamacy.Areas.Identity.Controllers
{
    [Area(AreaConstants.IdentityArea)]
    [Authorize]
    [BreadCrumb(Title = "مدیریت قفسه ها", UseDefaultRouteUrl = true, Order = 0)]
    public class ShelfController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}