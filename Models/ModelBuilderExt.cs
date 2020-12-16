using Microsoft.EntityFrameworkCore;

namespace NetCoreSimpleAPI.Models
{
    public static class ModelBuilderExt
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            byte[] pass = System.Text.Encoding.ASCII.GetBytes("123456");
            pass = new System.Security.Cryptography.SHA256Managed().ComputeHash(pass);

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "Pablo", Password = pass }
            );

        }
    }
}
