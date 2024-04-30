using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace RentACar.WebUI.ViewComponents.TestimonialViewComponents
{
    public class TestimonialComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TestimonialComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7047/api/Testimonials");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonDate = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<string>>(jsonDate);
                return View(values);
            }

            return View();
        }
    }
}
