using CSI350VetMidterm.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//*****Register the database LocalConnection is the name used in appsettings.json.  
//*****This is our dependency injection
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LocalConnection")));

//*****Add Roles to the Identity service.  AddRoles<IdentityRole>()  goes before AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();


//*****Add builder.Services.AddRazorPages();  let's us use Razor Pages.
builder.Services.AddRazorPages();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
//*****Add app.MapRazorPages();  It configures routing for identity.
app.MapRazorPages();

//*****MapControllerRoute lets us make a custom route template.
//We can use contraints in the URL:
//  : to specify the data type.  :int will make the parameter only an int.  
app.MapControllerRoute(name: "species",
pattern: "patient/{id:int}/species/{species?}",
defaults: new { controller = "Patient", action = "Details" }
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


//*****Adding Roles
//Seed Roles
using (var scope = app.Services.CreateScope())
{
    //Get Role Manager, provided by IdentityFramework
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    //Add AddRoles<IdentityRole>() to the AddDefaultIdentity Service above in Program.cs

    //Make an array to hold the role titles
    var roles = new[] { "Admin", "Employee", "Client" };

    //If these roles already exist, we don't want to recreate them.
    foreach (var role in roles)
    {
        //Search in the database (async call) so we need to call await
        if (!await roleManager.RoleExistsAsync(role))
        {
            //If the role doesn't exist, we'll create it.
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }

}//End of using(seed roles)


//*****Seed Admin
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

    //Create Admin user.  Set email and password.
    string email = "email@email.com";
    string password = "Password123#";

    //If the user doesn't exsist yet, create the account.
    if (await userManager.FindByEmailAsync(email) == null)
    {
        //If they don't exist, create the account.
        var user = new IdentityUser(email);
        user.UserName = email;
        user.Email = email;
        //Make sure we confirm email confirmation
        user.EmailConfirmed = true;
        //Don't add the password here because it needs to be hashed for security reasons.  We don't want a password in plain text.
        await userManager.CreateAsync(user, password);

        //Create role table to connect roles to user
        await userManager.AddToRolesAsync(user, ["Admin", "Employee"]);
    }

}//End of using(seed admin)

//Seed other users
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

    //Create user emails and passwords
    string email1 = "employee@email.com";
    string password1 = "Password123#";

    string email2 = "client@email.com";
    string password2 = "Password123#";

    //Make sure the users don't already exist.
    //User 1
    if (await userManager.FindByEmailAsync(email1) == null)
    {
        var user1 = new IdentityUser(email1);
        user1.UserName = email1;
        user1.Email = email1;
        user1.EmailConfirmed = true;
        await userManager.CreateAsync(user1, password1);

        //Set role
        await userManager.AddToRoleAsync(user1, "Employee");
    }

    //User 2
    if (await userManager.FindByEmailAsync(email2) == null)
    {
        var user2 = new IdentityUser(email2);
        user2.UserName = email2;
        user2.Email = email2;
        user2.EmailConfirmed = true;
        await userManager.CreateAsync(user2, password2);

        //Set role
        await userManager.AddToRoleAsync(user2, "Client");
    }
}//End of using(seeding other users)

app.Run();

