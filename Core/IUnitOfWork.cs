using System.Threading.Tasks;

namespace asp.net_core_angular.Core
{
    public interface IUnitOfWork
    {
        Task Complete();
    }
}