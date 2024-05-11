using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentACar.Dto.ServiceDTOS;

namespace RentACar.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        
        public  IActionResult Index()
        {
           return View();
        }
    }
}
