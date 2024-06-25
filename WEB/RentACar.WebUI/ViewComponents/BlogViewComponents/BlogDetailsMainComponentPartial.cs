using Microsoft.AspNetCore.Mvc;

namespace RentACar.WebUI.ViewComponents.BlogViewComponents
{
    public class BlogDetailsMainComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
             return View();
        }
    }
}
