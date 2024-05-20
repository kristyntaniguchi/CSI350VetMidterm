using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSI350VetMidterm.Data;
using CSI350VetMidterm.Models;

namespace CSI350VetMidterm.Controllers
{
    public class VeterinarianController : Controller
    {
        //Veterinarian should contain the following Actions:
        //Index, Detail, Create, (post)Create, Edit, (post) Edit, Delete, (post)Delete 

        //Inject database
        ApplicationDbContext _context;

        //Add constructor
        public VeterinarianController(ApplicationDbContext context)
        {
            _context = context;
        }//End of Constructor

        //async lets tasks run concurrently instead of sequentially so the app doesn't have to wait for slower functions to finish before running others. 
        public async Task<IActionResult> Index()
        {
            //Get the list of veterinarians
            IEnumerable<Veterinarian> veterinarians = _context.Veterinarians;

            return View(veterinarians);
        }//End of Index()

        public async Task<IActionResult> Details(int? id)
        {
            //Make sure the id is in the database.  Return 404 if it's not.
            if(id == null)
            {
                return NotFound();
            }

            //use the id to get the vet
            Veterinarian veterinarian = await _context.Veterinarians.FirstOrDefaultAsync(veterinarian => veterinarian.Id == id);

            //If the vet is empty, return 404
            if(veterinarian == null)
            {
                return NotFound();
            }

            //Return the vet
            return View(veterinarian);

        }//End of Details()


        //Don't need to label [HttpGet] because ASP.NET MVC and Core treat actions without an HTTP attribute as a Get
        //Only allow admins to edit
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            //If the id isn't valid, return 404
            if(id==null)
            {
                return NotFound();
            }

            //Get the vet with the id
            Veterinarian veterinarian = await _context.Veterinarians.FindAsync(id);

            //Make sure the vet object isn't empty
            if(veterinarian == null)
            {
                return NotFound();
            }

            //Send the vet to the view
            return View(veterinarian);

        }//End of [HttpGet] Edit()

        [Authorize(Roles = "Admin")]
        [HttpPost]
        //ValidateAntiForgeryToken helps defend against cross-site request forgery
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name, YearsExperience, Bio, ImgURL")] Veterinarian veterinarian)
        {
            //If the id parameter doesn't match the vet id, return 404
            if(id != veterinarian.Id)
            {
                return NotFound();
            }

            //If the model state is valid
            if(ModelState.IsValid)
            {
                try
                {
                    //Update the vet in the database and save changes
                    _context.Update(veterinarian);
                    await _context.SaveChangesAsync();

                }//End of try

                //DbUpdateConcurrencyException throws when an update to the database fails because the same data is trying to be updated multiple times concurrently.
                catch (DbUpdateConcurrencyException)
                {
                    //If the vet doesn't exist, return 404
                    if (!VeterinarianExists(veterinarian.Id))
                    {
                        return NotFound(ModelState);
                    }
                    else
                    {
                        //Re throw any unexpected errors
                        throw;
                    }

                }//End of catch
                
                //The vet edit is valid.  Returning the user to the vet's updated details page.
                return RedirectToAction("Details", new {id});
            }//End of if(ModelState.IsValid)

            //If the Model isn't valid, return them to the edit page
            return View(veterinarian);

        }//End of [HttpPost] Edit()


        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }//End of [HttpGet] Create()

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Name, YearsExperience, Bio, ImgURL")] Veterinarian veterinarian)
        {
            //If the model state is valid
            if (ModelState.IsValid)
            {
                //Add the vet to the database and save 
                _context.Add(veterinarian);
                await _context.SaveChangesAsync();

                //Redirect to the new vet's details page
                return RedirectToAction("Details", new { id = veterinarian.Id });
            }

            //If the model isn't valid, return to the create page
            return View(veterinarian);
        }//End of [HttpPost] Create()


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            //Check if the id exists
            if(id == null)
            {
                //Return 404 if id isn't found
                return NotFound();
            }

            //Store the vet with the matching id
            Veterinarian veterinarian = await _context.Veterinarians.FirstOrDefaultAsync(v => v.Id == id);

            //If the vet object is empty, return not found
            if(veterinarian == null)
            {
                return NotFound();
            }

            //Send the vet to the view
            return View(veterinarian);

        }//End of [HttpGet] Delete

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            //Use the id parameter to get the vet from the database
            Veterinarian veterinarian = await _context.Veterinarians.FindAsync(id);

            //If the veterinarian object isn't empty, remove it from the database
            if(veterinarian != null)
            {
                _context.Veterinarians.Remove(veterinarian);
            }

            //Save changes
            await _context.SaveChangesAsync();

            //Redirect user to index page
            return RedirectToAction("Index");

        }//End of [HttpPost] Delete()



        //Methods===========================================================================================================
        //Returns true or false based if a vet exists int the database.
        private bool VeterinarianExists(int id)
        {
            return _context.Veterinarians.Any(v => v.Id == id);
        }
    }//End of class
}
