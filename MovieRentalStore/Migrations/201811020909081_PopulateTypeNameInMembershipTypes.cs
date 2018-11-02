using System.Data.Entity.Migrations.Model;

namespace MovieRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTypeNameInMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET TypeName = 'Pay As You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET TypeName = '1 Month' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET TypeName = '3 Months' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET TypeName = '1 Year' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
