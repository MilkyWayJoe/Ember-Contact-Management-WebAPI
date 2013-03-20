namespace Ember_Contact_Management_WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact_data_annotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "MiddleName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "Nickname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "PictureUrl", c => c.String(maxLength: 255));
            AlterColumn("dbo.Contacts", "Twitter", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "Facebook", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "Website", c => c.String(maxLength: 100));
            AlterColumn("dbo.Contacts", "Notes", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Notes", c => c.String());
            AlterColumn("dbo.Contacts", "Website", c => c.String());
            AlterColumn("dbo.Contacts", "Facebook", c => c.String());
            AlterColumn("dbo.Contacts", "Twitter", c => c.String());
            AlterColumn("dbo.Contacts", "PictureUrl", c => c.String());
            AlterColumn("dbo.Contacts", "Nickname", c => c.String());
            AlterColumn("dbo.Contacts", "LastName", c => c.String());
            AlterColumn("dbo.Contacts", "MiddleName", c => c.String());
            AlterColumn("dbo.Contacts", "FirstName", c => c.String());
        }
    }
}
