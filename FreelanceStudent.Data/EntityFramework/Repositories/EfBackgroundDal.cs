using FreelanceStudent.Data.Abstract;
using FreelanceStudent.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreelanceStudent.Data.EntityFramework.Repositories
{
    public class EfBackgroundDal : RepositoryBase<Background>, IBackgroundDal
    {
        public EfBackgroundDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
