using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreelanceStudent.Core.Services;
using FreelanceStudent.Entity.DTOs;
using FreelanceStudent.Entity.Entities;

namespace FreelanceStudent.Service.Abstract
{
    public interface IAdvertService : IGenericService<Advert,AdvertDto>
    {
    }
}
