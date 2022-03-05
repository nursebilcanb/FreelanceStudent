using FreelanceStudent.Core.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreelanceStudent.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        public IActionResult ActionResultInstance<TEntity>(CustomResponse<TEntity> response) where TEntity : class
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
