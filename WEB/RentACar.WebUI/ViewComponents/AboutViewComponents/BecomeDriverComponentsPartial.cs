using Microsoft.AspNetCore.Mvc;

namespace RentACar.WebUI.ViewComponents.AboutViewComponents
{
    public class BecomeDriverComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
