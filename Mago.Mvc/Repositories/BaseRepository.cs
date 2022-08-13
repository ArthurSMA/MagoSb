namespace Mago.Mvc.Repositories
{
    public class BaseRepository 
    {
        private readonly DbContext _dbContext;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
