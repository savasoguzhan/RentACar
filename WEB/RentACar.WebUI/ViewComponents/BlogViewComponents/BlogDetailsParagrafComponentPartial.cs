using Microsoft.AspNetCore.Mvc;

namespace RentACar.WebUI.ViewComponents.BlogViewComponents
{
    public class BlogDetailsParagrafComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
