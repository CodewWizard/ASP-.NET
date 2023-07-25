namespace MVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "codewizard-Employee",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        EmpName = c.String(),
                        EmpCity = c.String(),
                        EmpGender = c.String(),
                        DepartmentID = c.Int(nullable: false, identity: true)
                    })
                .PrimaryKey(t => t.EmpId);
        }
        
        public override void Down()
        {
            DropTable("dbo.codewizard-Employee");
        }
    }
}
