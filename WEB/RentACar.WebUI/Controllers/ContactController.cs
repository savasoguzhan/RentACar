using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentACar.Dto.ContactDTOS;
using System.Text;

namespace RentACar.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDtos createContactDtos)
        {
            var client = _httpClientFactory.CreateClient();
            createContactDtos.SendData=DateTime.Now;
            var jsonData = JsonConvert.SerializeObject(createContactDtos);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:7047/api/Contact/", stringContent);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index","Default");

            }
            return View();
        }
    }
}
