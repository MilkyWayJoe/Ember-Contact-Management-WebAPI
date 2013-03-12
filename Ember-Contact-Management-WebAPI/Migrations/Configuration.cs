namespace Ember_Contact_Management_WebAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Ember_Contact_Management_WebAPI.Models.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Ember_Contact_Management_WebAPI.Models.AppContext context)
        {
           
        }
    }
}
