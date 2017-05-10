using System.Data.Entity;

namespace testing.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=UserConnection")
        {
        }
        public DbSet<User> Clients { get; set; }
    }

    public class UserDbInitialize : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            context.Clients.Add(new User { Name = "Nazar", Login = "Nazi", Password = "12345", Surname = "Kravchuk" });
            context.Clients.Add(new User { Name = "Taras", Login = "Tarik", Password = "12345", Surname = "Savechko" });
            context.Clients.Add(new User { Name = "Komar", Login = "Svat", Password = "12345", Surname = "Komar" });

            base.Seed(context);
        }
    }
}