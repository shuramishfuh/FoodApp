using System;
using System.Threading.Tasks;

namespace JWTAuthentication.WebApi.Repositories.UnitOfWork
{
    public interface IUnitOfWork: IAsyncDisposable
    {
        Task<int> Complete();
    }
}
