using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClinicaVeterinaria.Models;
using Microsoft.AspNetCore.Authorization;

namespace ClinicaVeterinaria.Controllers;

[Authorize]
public class HomeController : Controller
{
    public IActionResult Index() => View();
    [AllowAnonymous]
    public IActionResult Error() => View(new ClinicaVeterinaria.Models.ErrorViewModel
    {
        RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier
    });
}