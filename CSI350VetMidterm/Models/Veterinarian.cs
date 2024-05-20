using System.ComponentModel.DataAnnotations;

namespace CSI350VetMidterm.Models
{
    public class Veterinarian
    {
        //Vet Model
        //Add properties: Id, Name, YearsExperience, Bio, ImgURL

        //Add data annotations
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Years of Experience")]
        public int YearsExperience { get; set; }

        public string Bio { get; set; }

        [Display(Name = "Image URL")]
        public string ImgURL { get; set; }
    }
}
