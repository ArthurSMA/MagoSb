namespace Mago.Mvc
{
    public class AppDbContext : BaseDbContext
    {
        public AppDbContext(AppSettings appSettings) : base(appSettings, "Application")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
