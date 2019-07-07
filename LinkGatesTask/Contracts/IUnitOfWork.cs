using System;
using System.Threading.Tasks;

namespace LinkGatesTask.Contracts
{
    public interface IUnitOfWork
    {
        void Commit();
        Task<int> CommitAsync();
    }
}
