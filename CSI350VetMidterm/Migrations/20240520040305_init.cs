using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSI350VetMidterm.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Medications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veterinarians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearsExperience = table.Column<int>(type: "int", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinarians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "Breed", "ImgURL", "MedicalHistory", "Medications", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 9, "Plott Hound", "", "Up to date on vaccinations. Seperation anxiety. Whines after meal times because he is so sad that his food is all gone", "NexGuard, HeartGuard, Cosequin", "Max", "Canine" },
                    { 2, 8, "Australian Cattle Dog / American Staffordshire Terrier", "", "Up to date on vaccinations. Prefers to be an only child", "NexGuard, HeartGuard, Cosequin", "Elsie", "Canine" },
                    { 3, 7, "German Shepherd", "", "Up to date on vaccinations. Autoimmune disorder. Extensive allergies", "Pentoxifylline, NexGuard, HeartGuard, Prednisone, Cosequin, Immunotherapy injections ", "Lila", "Canine" },
                    { 4, 5, "Labrador Retriever", "", "Up to date on vaccinations. Autoimmune disorder. Extensive allergies", "NexGuard, HeartGuard, Cosequin, Immunotherapy injections", "Lucy", "Canine" },
                    { 5, 4, "Corgi", "", "Up to date on vaccinations. Attitude issues. Wishes he was an only child", "NexGuard, HeartGuard, Cosequin", "Gus", "Canine" },
                    { 6, 3, "English Labrador Retriever", "", "Up to date on vaccinations. Very wiggly, possibly made of Jell-O", "NexGuard, HeartGuard, Cosequin", "Ellie", "Canine" },
                    { 7, 1, "Red Eared Slider", "", "Healthy", "N/A", "Lenny", "Chelonian" },
                    { 8, 6, "American Shorthair", "", "Upper respiratory virus. Heart murmur", "Flea Preventative", "Rudy", "Feline" },
                    { 9, 5, "American Shorthair", "", "Chews cardboard. Not fond of other cats. Cattitude", "Flea Preventative", "Leo", "Feline" },
                    { 10, 4, "626", "https://insidethemagic.net/wp-content/uploads/2020/03/Screen-Shot-2020-03-26-at-9.21.17-AM-550x324.png", "Genetically engineered, extraterrestrial life-form.", "Coffee", "Stitch", "Experiment" }
                });

            migrationBuilder.InsertData(
                table: "Veterinarians",
                columns: new[] { "Id", "Bio", "ImgURL", "Name", "YearsExperience" },
                values: new object[,]
                {
                    { 1, "Born and raised on Kauai, Nani is a compassionate veterinarian and cares deeply for animals. With her warm heart and gentle touch, she provides exceptional care to her patients, earning their trust and affection. Nani's dedication to animal welfare extends beyond the clinic as she volunteers to rescue and rehabilitate injured wildlife, making her a beloved figure in the veterinary community. In her free time, Nani enjoys surfing, spending time outdoors with her sister, Lilo, and hiking with their dog, Stitch.", "https://64.media.tumblr.com/f1e99003c04ec93242249f0b1ebb9b9e/tumblr_pvsdy8OAVI1xqfmwso1_1280.png", "Nani Pelekai", 7 },
                    { 2, "A Kauai native, David is a caring veterinarian with a deep love for animals. With his gentle touch and genuine compassion, he provides exceptional care to his patients, both in the clinic and in wildlife rescue efforts. In his free time, David enjoys surfing, snorkeling, and fire dancing.", "https://img.buzzfeed.com/buzzfeed-static/static/2023-04/25/22/campaign_images/29eff9769411/the-role-of-david-in-the-live-action-lilo-stitch--3-1447-1682462498-0_dblbig.jpg?resize=1200:*", "David Kawena", 7 },
                    { 3, "Prior to becoming a veterinarian, Cobra spent time working in law enforcement.  He approaches animal care with efficiency and professionalism. Despite his stern demeanor, he's deeply empathetic and dedicated to the well-being of all creatures, making him a respected figure in both the veterinary and conservation communities. Cobra enjoys spending his free time practicing martial arts, mentoring at-risk youth, listening to jazz music, and is also passionate about mosquito conservation. ", "https://static1.cbrimages.com/wordpress/wp-content/uploads/2023/04/lilo-and-stirch-agent-cobra-bubbles.jpg", "Cobra Bubbles", 18 },
                    { 4, "Born and raised on Kauai, Lilo has a passion helping for animals. She adopted her first dog, Stitch, when she was 6 years old.", "https://akns-images.eonline.com/eol_images/Entire_Site/2023231/rs_1200x1200-230331155207-1200-lilo-stitch-shutterstock_editorial_384800f.jpg?fit=around%7C1200:1200&output-quality=90&crop=1200:1200", "Lilo Pelekai", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Veterinarians");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
