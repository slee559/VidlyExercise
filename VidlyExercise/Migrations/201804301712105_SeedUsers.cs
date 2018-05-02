namespace VidlyExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'346b6414-1c33-45cf-86a8-af5be4b7705f', N'brian@gmail.com', 0, N'AKA+8yulg1Cdr1Lz9Q17C/c3RD2f2iutN2+zyPChlJp9OB4vzB6YQKxLBR+J3cA5RA==', N'7bb381f6-345b-494e-baeb-673c0448f693', NULL, 0, 0, NULL, 1, 0, N'brian@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'493c301a-34a9-4599-85a7-00f5790cbda4', N'admin@gmail.com', 0, N'AHK5nQRJloR9eAe1g8nfbSQ74ExW9ik87tss+7spm3Wk9GMpNHPp89mLzyek9lZq1g==', N'a57a5dac-0694-4f11-910d-b3816441ad72', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'131b2fb9-f29e-486e-a196-15f41feda8bc', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'493c301a-34a9-4599-85a7-00f5790cbda4', N'131b2fb9-f29e-486e-a196-15f41feda8bc')
");
        }
        
        public override void Down()
        {
        }
    }
}
