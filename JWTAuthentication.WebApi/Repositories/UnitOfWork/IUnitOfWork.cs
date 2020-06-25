using System;
using System.Threading.Tasks;

namespace JWTAuthentication.WebApi.Repositories.UnitOfWork
{
    interface IUnitOfWork: IDisposable
    {
        Task<int> Complete();
    }
}
