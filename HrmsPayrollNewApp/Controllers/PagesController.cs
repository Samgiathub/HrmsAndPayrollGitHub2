using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HrmsPayrollNewApp.Models;

namespace HrmsPayrollNewApp.Controllers;

public class PagesController : Controller
{
  public IActionResult AccountSettings() => View();
  public IActionResult AccountSettingsConnections() => View();
  public IActionResult AccountSettingsNotifications() => View();
  public IActionResult MiscError() => View();
  public IActionResult MiscUnderMaintenance() => View();
}
