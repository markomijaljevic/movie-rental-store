namespace MovieRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationsToMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "TypeName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "TypeName", c => c.String());
        }
    }
}
