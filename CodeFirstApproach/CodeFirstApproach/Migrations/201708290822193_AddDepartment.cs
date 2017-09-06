namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartment : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CodeFirsts", name: "DeptId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.CodeFirsts", name: "Name", newName: "DeptId");
            RenameColumn(table: "dbo.CodeFirsts", name: "__mig_tmp__0", newName: "DeptId1");
            AlterColumn("dbo.CodeFirsts", "DeptId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CodeFirsts", "DeptId", c => c.Int(nullable: false, identity: true));
            RenameColumn(table: "dbo.CodeFirsts", name: "DeptId1", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.CodeFirsts", name: "DeptId", newName: "Name");
            RenameColumn(table: "dbo.CodeFirsts", name: "__mig_tmp__0", newName: "DeptId");
        }
    }
}
