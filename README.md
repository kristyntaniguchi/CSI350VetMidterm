I made a web app for a veterinary office using ASP.NET Core and MVC.  There are 2 models, Veterinarian and Patient.  The VeterinarianController has full CRUD functionality, views for each function, and requires authorization access the Create, Edit, and Delete actions.  I also implemeted the Dynamic Dropdown Menu for the veterinarians that links to their details page.  The PatientController contains Index, Detail, and Create functions, has views set up for each, and uses URL Routing for the Details function.  Some features in the navbar aren't functional yet, but I wanted to make it more visually appealing.  

Features in the navbar that are working are the "Our Veterinarians" link, "Patients" link, and Veterinarians dropdown menu.  

Through the "Our Veterinarians" link, you'll be directed to the veterinarian index page where all of the veterinarian's in the database are listed.  The veterinarian index page has the option to create a new veterinarian, however this feature is only available and visible to authorized Admin users.  All users can click on any one of the cards to view that vet's details page, which contains the vet's biography and years of experience.  The veterinarian details pages also have the option to edit or delete that specific vet's profile, however these features are only available and visible to Admin users.  

The dropdown menu in the navbar also provides direct access to any of the veterinarian details pages by clicking on the name of the vet you'd like to view.  

The "Patients" link provides a list of all patients in the database, along with their profile image, name, species, breed, and age.  The patients index page also provides authorized Admin users with the option to create a new patient.  The option to create a new patient is only available and visible to Admin users.  From the patient index page, the patient's details can be viewed by clicking on their image, name, species, breed, or age.  

Only Admin users can see and access the options to create a new veterinarian profile, edit or delete an existing veterinarian's profile, and create a new patient profile.

Create a new veterinarian:
The button to create a new veterinarian profile is located on the upper right of the veterinarian index page.  In order to create a new veterinarian, the following fields are required: a name, biography, number of years of experience, and an image URL link.  
All fields must be filled in order to create a veterinarian profile. 

Edit a veterinarian profile:
The option to edit a vet's profile is located in their details page.  Once their details page is open, select the Edit button located under their bio and make the desired changes.  All fields must be filled out in order to save the changes.  Once the changes are complete, select the save button.  If you do not want to save the changes, select the cancel button.

Delete a veterinarian profile: 
The button to delete a vet's profile is locted in their details page, underneath their bio.  Selecting the delete button in their bio will direct you to a confirmation page, where you'll be asked to confirm if you want to delete the profile.  If you want to continue with the deletion, select the delete button.  If you do not want to delete the profile, select the cancel button.  Deleting is permanent and cannot be undone.  

Create a new patient:
The option to create a new patient profile is located in the upper right of the patient index page.  In order to create a new patient, the following fields are required: name, species, breed, age, medications, medical history, and an image URL link.
All fields must be filled in order to create a  patient profile.  
