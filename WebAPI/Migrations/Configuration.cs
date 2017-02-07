namespace WebAPI.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Structure;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPI.Structure.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "baileymiller@live.com",
                Email = "baileymiller@live.com",
                EmailConfirmed = true,
                FirstName = "Bailey",
                LastName = "Miller",
                Level = 1,
                JoinDate = DateTime.Now.AddYears(-20)
            };

            manager.Create(user, "MySuperP@ssword!");
        }
    }
}
