using System.Threading.Tasks;
using JWTAuthentication.WebApi.Contexts;

namespace JWTAuthentication.WebApi.Repositories.UnitOfWork
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        

        public Task<int> Complete()
        {
          return _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.DisposeAsync();
        }
    }
}
