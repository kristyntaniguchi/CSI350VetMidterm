using Microsoft.AspNetCore.Mvc;

namespace CSI350VetMidterm.ViewComponents
{
    //Inherit from ViewComponent and add its using statement Microsoft.AspNetCore.Mvc;
    public class VeterinarianDynamicDropdownMenuViewComponent : ViewComponent
    {
        //Synchronous
        //public IViewComponentResult Invoke()
        //{
        //    return View();
        //}

        //Async
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }//End of Invoke()

    }//End of class
}
