using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentACar.Dto.CarDTOS;
using RentACar.Dto.CarPricingDTOS;

namespace RentACar.WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Araçlar";
            ViewBag.v2 = "Araçlarımız";

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7047/api/CarPricings");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarPricingWithCarDtos>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
