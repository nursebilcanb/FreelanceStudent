using System.Threading.Tasks;

namespace FreelanceStudent.Core.IUnitOfWork
{
    public interface IUnitOfWork
    {
       // IProductRepository Products { get; }
       // ICategoryRepository Category { get; }

        Task CommitChangesAsync();
        void CommitChanges();

    }
}
