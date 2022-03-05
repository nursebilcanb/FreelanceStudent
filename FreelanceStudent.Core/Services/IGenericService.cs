using FreelanceStudent.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceStudent.Core.Services
{
    public interface IGenericService<TEntity, TDto> where TEntity : class where TDto : class
    {
        Task<CustomResponse<TDto>> GetByIdAsync(int id);

        Task<CustomResponse<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> predicate);

        Task<CustomResponse<IEnumerable<TDto>>> GetAllAsync();

        Task<CustomResponse<TDto>> AddAsync(TDto entity);

        Task<CustomResponse<NoContent>> Remove(int id);

        Task<CustomResponse<NoContent>> Update(TDto entity, int id);
    }
}
