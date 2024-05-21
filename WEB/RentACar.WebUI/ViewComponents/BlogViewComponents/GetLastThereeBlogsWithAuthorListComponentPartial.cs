using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentACar.Dto.BlogDTOS;

namespace RentACar.WebUI.ViewComponents.BlogViewComponents
{
    public class GetLastThereeBlogsWithAuthorListComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GetLastThereeBlogsWithAuthorListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7047/api/Blogs/GetLastThereeBlogsWithAuthor");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLastThereeBlogs>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
