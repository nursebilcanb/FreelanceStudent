using FreelanceStudent.Core.Repositories;
using FreelanceStudent.Data.Abstract;
using FreelanceStudent.Entity.Entities;
using FreelanceStudent.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceStudent.Data.EntityFramework
{
    public class EfCategoryDal : RepositoryBase<Category>, ICategoryDal
    {
        public EfCategoryDal(DbContext dbContext, DbSet<Category> dbSet) : base(dbContext, dbSet)
        {
        }
    }
}
