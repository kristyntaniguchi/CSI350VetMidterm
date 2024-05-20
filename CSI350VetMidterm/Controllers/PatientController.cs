using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSI350VetMidterm.Data;
using CSI350VetMidterm.Models;


namespace CSI350VetMidterm.Controllers
{
    public class PatientController : Controller
    {
        //Patient Controller should contain: Index, Details, Create, (post) Create

        //Inject the database
        ApplicationDbContext _context;

        //Constructor
        public PatientController(ApplicationDbContext context)
        {
            _context = context;
        }//End of Constructor

        //Displays all patients
        public async Task<IActionResult> Index()
        {
            //Get the list of patients
            IEnumerable<Patient> patients = _context.Patients;

            //Send the list to the view
            return View(patients);
        }//End of Index()

        //Add asp-route-species="@p.Species" in the URL helpers that direct to the Details page.
        //Remember that it's route-species because species is the word we want to add to the url route.
        [Route("patient/{id:int}/species/{species?}")]
        public async Task<IActionResult> Details (int? id)
        {
            //If the id doesn't exist, return 404
            if(id == null)
            {
                return NotFound();
            }

            //Get the patient object with the id passed in
            Patient patient = await _context.Patients.FirstOrDefaultAsync(patient => patient.Id == id);

            //If the patient object is empty, return 404
            if(patient == null)
            {
                return NotFound();
            }

            //Send the patient to the view
            return View(patient);
        }//End of Details()

        public IActionResult Create()
        {
            return View();
        }//End of [HttpGet] Create()

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Name, Species, Breed, Age, Medications, MedicalHistory, ImgURL")] Patient patient)
        {
            //If the model state is valid
            if (ModelState.IsValid)
            {
                //Add the vet to the database and save 
                _context.Add(patient);
                await _context.SaveChangesAsync();

                //Redirect to the new vet's details page
                return RedirectToAction("Details", new { id = patient.Id });
            }

            //If the model isn't valid, return to the create page
            return View(patient);
        }//End of [HttpPost] Create()

    }//End of class
}
