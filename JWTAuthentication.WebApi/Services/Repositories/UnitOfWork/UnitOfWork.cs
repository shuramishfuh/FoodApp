using System.Threading.Tasks;
using JWTAuthentication.WebApi.Contexts;

namespace JWTAuthentication.WebApi.Services.Repositories.UnitOfWork
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            // instantiate all repos and pass _context
        }
        

        public Task<int> Complete()
        {
          return _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
