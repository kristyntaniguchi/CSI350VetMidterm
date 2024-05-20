using System.ComponentModel.DataAnnotations;

namespace CSI350VetMidterm.Models
{
    public class Patient
    {
        //Patient Model

        //Add properties: Id, Name, Species, Breed, Age, Medications, MedicalHistory, ImgURL

        //Add necessary data annotations
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Species { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public string Medications { get; set; }

        [Display(Name = "Medical History")]
        public string MedicalHistory { get; set; }

        [Display(Name = "Image URL")]
        public string ImgURL { get; set; }
    }
}
