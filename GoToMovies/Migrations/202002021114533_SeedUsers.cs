namespace GoToMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8f42f76b-bc66-4977-8b9d-34f10fdbd480', N'admin@vidiflex.com', 0, N'AIUoP98Gdd1vAZH7Lxt8WNJMFaCGLvP7O1Cc/PkTG7IHeERIXTNwGv+DNC2/8ioAYg==', N'68a94a8d-287f-480a-aed7-37a45395fcce', NULL, 0, 0, NULL, 1, 0, N'admin@vidiflex.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b5db36cf-d508-4b80-8b03-3edb699c3f84', N'guest@vidiflex.com', 0, N'APqYj/b98zaOmcqBp22fnntIRcLMaZ6aVgWWkWYhEICvh5ytXdffC8WV4MpmY+wTlA==', N'a5ecaaa4-94ba-4eb6-9f34-f8556f959a5e', NULL, 0, 0, NULL, 1, 0, N'guest@vidiflex.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8db31e2b-6379-4432-b577-bd5d2d89eaba', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8f42f76b-bc66-4977-8b9d-34f10fdbd480', N'8db31e2b-6379-4432-b577-bd5d2d89eaba')
");
        }
        
        public override void Down()
        {
        }
    }
}
