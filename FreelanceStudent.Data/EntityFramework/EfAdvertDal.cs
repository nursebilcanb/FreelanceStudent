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
    public class EfAdvertDal : RepositoryBase<Advert>, IAdvertDal
    {
        public EfAdvertDal(DbContext dbContext, DbSet<Advert> dbSet) : base(dbContext, dbSet)
        {
        }
    }
}
