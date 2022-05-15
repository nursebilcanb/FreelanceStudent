using FreelanceStudent.Data.Abstract;
using FreelanceStudent.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreelanceStudent.Data.EntityFramework.Repositories
{
    public class EfCategoryDal : RepositoryBase<Category>, ICategoryDal
    {
        public EfCategoryDal(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
