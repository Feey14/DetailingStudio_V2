using DetailingStudio_v2.Enums;
using DetailingStudio_v2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace DetailingStudio_v2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Affiliate> Affiliates { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<Order>()
                .Property(e => e.CarBodyType)
                .HasConversion(
                    v => v.ToString(),
                    v => (CarBodyType)Enum.Parse(typeof(CarBodyType), v));

            builder
                .Entity<Order>()
                .Property(e => e.OrderPaymentStatus)
                .HasConversion(
                    v => v.ToString(),
                    v => (OrderPaymentStatus)Enum.Parse(typeof(OrderPaymentStatus), v));

            builder
                .Entity<Order>()
                .Property(e => e.OrderStatus)
                .HasConversion(
                    v => v.ToString(),
                    v => (OrderStatus)Enum.Parse(typeof(OrderStatus), v));

/*            builder.Entity("dotnet_rpg.Models.CharacterSkill", b =>
            {
                b.HasOne("dotnet_rpg.Models.Character", "Character")
                    .WithMany("CharacterSkills")
                    .HasForeignKey("CharacterId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
                b.HasOne("dotnet_rpg.Models.Skill", "Skill")
                    .WithMany("CharacterSkills")
                    .HasForeignKey("SkillId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });*/

            /*            ApplicationUser appUser = new ApplicationUser
                        {
                            //Id = "a141dc7f-3170-4c9f-b6e6-3a3856f1b746",
                            UserName = "tester",
                            Email = "tester@tester.com",
                            NormalizedEmail = "tester@tester.com".ToUpper(),
                            NormalizedUserName = "tester".ToUpper(),
                            TwoFactorEnabled = false,
                            LockoutEnabled = true,
                            EmailConfirmed = true,
                            PhoneNumber = "123456789",
                            PhoneNumberConfirmed = false,
                            Name = "TesterName",
                            Surname = "TesterSurname"
                        };

                        PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
                        appUser.PasswordHash = ph.HashPassword(appUser, "Tester123)");

                        builder.Entity<IdentityRole>().HasData(
                            new IdentityRole { Id = "774e1b22-0ad3-456a-b5c4-48aa886700ff", Name = "Administrator", NormalizedName = "ADMINISTRATOR" }
                        );


                        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
                        {
                            RoleId = "774e1b22-0ad3-456a-b5c4-48aa886700ff",
                            UserId = "a141dc7f-3170-4c9f-b6e6-3a3856f1b746"
                        });

                        builder.Entity<ApplicationUser>().HasData(
                            appUser
                        );*/
        }
    }
}
