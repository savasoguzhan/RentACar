using Microsoft.AspNetCore.Mvc;

namespace RentACar.WebUI.ViewComponents.BlogViewComponents
{
    public class BlogDetailSideBarSearchBoxComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
