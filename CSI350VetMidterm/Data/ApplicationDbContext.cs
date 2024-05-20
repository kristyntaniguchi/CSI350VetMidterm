using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CSI350VetMidterm.Models;
using Microsoft.AspNetCore.Identity;

namespace CSI350VetMidterm.Data
{
    //Inherit from IdentityDbContext<WhateverUserNameIsUsed>
    //Do this before scaffolding so it will make ApplicationDbContext available when we do the scaffolding
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        //Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }//End of Constructor

        //Add the models (tables) as DbSet<t> ModelNamePlural {get; set}
        public DbSet<Veterinarian> Veterinarians { get; set; }
        public DbSet<Patient> Patients { get; set; }

        //Add Connection string in appsettings.json

        //Add OnModelCreating
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //Seed Data

            //Veterinarians
            builder.Entity<Veterinarian>().HasData(
                new Veterinarian { 
                    Id = 1, 
                    Name = "Nani Pelekai", 
                    YearsExperience = 7, 
                    Bio = "Born and raised on Kauai, Nani is a compassionate veterinarian and cares deeply for animals. With her warm heart and gentle touch, she provides exceptional care to her patients, earning their trust and affection. Nani's dedication to animal welfare extends beyond the clinic as she volunteers to rescue and rehabilitate injured wildlife, making her a beloved figure in the veterinary community. In her free time, Nani enjoys surfing, spending time outdoors with her sister, Lilo, and hiking with their dog, Stitch.", 
                    ImgURL = "https://64.media.tumblr.com/f1e99003c04ec93242249f0b1ebb9b9e/tumblr_pvsdy8OAVI1xqfmwso1_1280.png"
                },
                new Veterinarian { 
                    Id = 2, 
                    Name = "David Kawena", 
                    YearsExperience = 7, 
                    Bio = "A Kauai native, David is a caring veterinarian with a deep love for animals. With his gentle touch and genuine compassion, he provides exceptional care to his patients, both in the clinic and in wildlife rescue efforts. In his free time, David enjoys surfing, snorkeling, and fire dancing.", 
                    ImgURL = "https://img.buzzfeed.com/buzzfeed-static/static/2023-04/25/22/campaign_images/29eff9769411/the-role-of-david-in-the-live-action-lilo-stitch--3-1447-1682462498-0_dblbig.jpg?resize=1200:*"
                },
                new Veterinarian { 
                    Id = 3, 
                    Name = "Cobra Bubbles", 
                    YearsExperience = 18, 
                    Bio = "Prior to becoming a veterinarian, Cobra spent time working in law enforcement.  He approaches animal care with efficiency and professionalism. Despite his stern demeanor, he's deeply empathetic and dedicated to the well-being of all creatures, making him a respected figure in both the veterinary and conservation communities. Cobra enjoys spending his free time practicing martial arts, mentoring at-risk youth, listening to jazz music, and is also passionate about mosquito conservation. ", 
                    ImgURL = "https://static1.cbrimages.com/wordpress/wp-content/uploads/2023/04/lilo-and-stirch-agent-cobra-bubbles.jpg"
                },
                new Veterinarian
                {
                    Id = 4, 
                    Name = "Lilo Pelekai",
                    YearsExperience = 1,
                    Bio = "Born and raised on Kauai, Lilo has a passion helping for animals. She adopted her first dog, Stitch, when she was 6 years old.",
                    ImgURL = "https://akns-images.eonline.com/eol_images/Entire_Site/2023231/rs_1200x1200-230331155207-1200-lilo-stitch-shutterstock_editorial_384800f.jpg?fit=around%7C1200:1200&output-quality=90&crop=1200:1200"

                }
                );

            //Patients
            builder.Entity<Patient>().HasData(
                new Patient
                {
                    Id = 1,
                    Name = "Max",
                    Species = "Canine",
                    Breed = "Plott Hound",
                    Age = 9,
                    Medications = "NexGuard, HeartGuard, Cosequin",
                    MedicalHistory = "Up to date on vaccinations. Seperation anxiety. Whines after meal times because he is so sad that his food is all gone",
                    ImgURL = "https://pbs.twimg.com/media/GOAF_fSa8AAF6yl?format=jpg&name=large"
                },
                new Patient
                {
                    Id = 2,
                    Name = "Elsie",
                    Species = "Canine",
                    Breed = "Australian Cattle Dog / American Staffordshire Terrier",
                    Age = 8,
                    Medications = "NexGuard, HeartGuard, Cosequin",
                    MedicalHistory = "Up to date on vaccinations. Prefers to be an only child",
                    ImgURL = "https://pbs.twimg.com/media/GOAF_fObQAE7eTW?format=jpg&name=large"
                },
                new Patient
                {
                    Id = 3,
                    Name = "Lila",
                    Species = "Canine",
                    Breed = "German Shepherd",
                    Age = 7,
                    Medications = "Pentoxifylline, NexGuard, HeartGuard, Prednisone, Cosequin, Immunotherapy injections ",
                    MedicalHistory = "Up to date on vaccinations. Autoimmune disorder. Extensive allergies",
                    ImgURL = "https://pbs.twimg.com/media/GOAGL3DaQAAfWPz?format=jpg&name=large"
                },
                new Patient
                {
                    Id = 4,
                    Name = "Lucy",
                    Species = "Canine",
                    Breed = "Labrador Retriever",
                    Age = 5,
                    Medications = "NexGuard, HeartGuard, Cosequin, Immunotherapy injections",
                    MedicalHistory = "Up to date on vaccinations. Autoimmune disorder. Extensive allergies",
                    ImgURL = "https://pbs.twimg.com/media/GOAHgqwbMAA3ODl?format=jpg&name=large"
                },
                new Patient
                {
                    Id = 5,
                    Name = "Gus",
                    Species = "Canine",
                    Breed = "Corgi",
                    Age = 4,
                    Medications = "NexGuard, HeartGuard, Cosequin",
                    MedicalHistory = "Up to date on vaccinations. Attitude issues. Wishes he was an only child",
                    ImgURL = "https://pbs.twimg.com/media/GOAGL3CasAAl78A?format=jpg&name=large"
                },
                new Patient
                {
                    Id = 6,
                    Name = "Ellie",
                    Species = "Canine",
                    Breed = "English Labrador Retriever",
                    Age = 3,
                    Medications = "NexGuard, HeartGuard, Cosequin",
                    MedicalHistory = "Up to date on vaccinations. Very wiggly, possibly made of Jell-O",
                    ImgURL = "https://pbs.twimg.com/media/GOAGj4tagAEcvkL?format=jpg&name=large"
                },
                new Patient
                {
                    Id = 7,
                    Name = "Lenny",
                    Species = "Chelonian",
                    Breed = "Red Eared Slider",
                    Age = 1,
                    Medications = "N/A",
                    MedicalHistory = "Healthy",
                    ImgURL = "https://pbs.twimg.com/media/GOAF_fTaoAAsKtp?format=jpg&name=large"
                },
                new Patient
                {
                    Id = 8,
                    Name = "Rudy",
                    Species = "Feline",
                    Breed = "American Shorthair",
                    Age = 6,
                    Medications = "Flea Preventative",
                    MedicalHistory = "Upper respiratory virus. Heart murmur",
                    ImgURL = "https://pbs.twimg.com/media/GOAF_fTbcAANpk9?format=jpg&name=large"
                },
                new Patient
                {
                    Id = 9,
                    Name = "Leo",
                    Species = "Feline",
                    Breed = "American Shorthair",
                    Age = 5,
                    Medications = "Flea Preventative",
                    MedicalHistory = "Chews cardboard. Not fond of other cats. Cattitude",
                    ImgURL = "https://pbs.twimg.com/media/GOAGL3CbUAAhgRf?format=jpg&name=large"
                }, 
                new Patient
                {
                    Id = 10,
                    Name = "Stitch",
                    Species = "Experiment", 
                    Breed = "626",
                    Age = 4,
                    Medications = "Coffee",
                    MedicalHistory = "Genetically engineered, extraterrestrial life-form.",
                    ImgURL = "stitch"
                }
                );


        }//End of OnModelCreating()

    }//End of class
}
