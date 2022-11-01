using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Visoft.Framework.Sanitary;

namespace AspCorAsWindowsService;

public class HomeController: Controller
{

    public IActionResult Index()
    {
        var res = SanitaryDescriptionHelper.GetSanitaryPrice(23234343);
        return View();
    }

}