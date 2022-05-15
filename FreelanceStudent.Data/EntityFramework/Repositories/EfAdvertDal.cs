using FreelanceStudent.Data.Abstract;
using FreelanceStudent.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreelanceStudent.Data.EntityFramework.Repositories
{
    public class EfAdvertDal : RepositoryBase<Advert>, IAdvertDal
    {
        public EfAdvertDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
