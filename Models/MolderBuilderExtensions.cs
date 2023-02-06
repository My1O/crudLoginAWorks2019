
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CRUDloginSQLwithEntityFramework.Models
{
    // dejamos la clase principal estatica
    public static class MolderBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Crear ROLES
            List<IdentityRole> roles = new List<IdentityRole>() {
                new IdentityRole { Name = "Administrador", NormalizedName = "ADMINISTRADOR" },
             

            };
            modelBuilder.Entity<IdentityRole>().HasData(roles);

            // Crear USERS
            List<ApplicationUser> users = new List<ApplicationUser>() {
                new ApplicationUser {
                    UserName = "My10@gmail.com",
                    NormalizedUserName = "MY10@GMAIL.COM",
                    Email = "My10@gmail.com",
                    NormalizedEmail = "MY10@GMAIL.COM",
                    EmailConfirmed = true
                }

            };
            modelBuilder.Entity<ApplicationUser>().HasData(users);

            // Agregar contraseña a los usuarios
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "milo150");


            // Agregar roles a usuario
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();
          
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId = roles.First(q => q.Name == "Administrador").Id
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
      }
    }

