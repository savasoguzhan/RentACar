using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentACar.Dto.FooterAddressDTOS;

namespace RentACar.WebUI.ViewComponents.FooterAddressComponents
{
    public class FooterAddressComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FooterAddressComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7047/api/FooterAddresses");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFooterAddressDtos>>(jsonData);
                return View (values);
            }
            return View();
        }
    }
}
