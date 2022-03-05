using System.Threading.Tasks;

namespace FreelanceStudent.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();

    }
}
