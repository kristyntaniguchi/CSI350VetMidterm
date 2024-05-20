using CSI350VetMidterm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSI350VetMidterm.Components
{
    //Inherit from ViewComponent and import using statement
    public class VeterinarianDropdownMenuViewComponent : ViewComponent
    {
        //The dropdown should show all of the veterinarians so we need ApplicationDbContext
        private readonly ApplicationDbContext _context;

        //Constructor
        public VeterinarianDropdownMenuViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }//End of Constructor

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Get the veterinarian info
            var vet = await _context.Veterinarians.ToListAsync();
            return View(vet);
        }//End of InvokeAsync()



    }//End of class
}
