using Microsoft.AspNetCore.Mvc;

namespace RealEstateUI.WiewComponents.Layout
{
    public class _HeaderViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            {
                return View();
            }
        }
    }
}
