using Microsoft.AspNetCore.Mvc;

namespace RentACar.WebUI.ViewComponents.BlogViewComponents
{
    public class BlogDetailsRecentBlogsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
