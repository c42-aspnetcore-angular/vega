using System.Threading.Tasks;

namespace asp.net_core_angular.Persistence
{
    public interface IUnitOfWork
    {
        Task Complete();
    }
}