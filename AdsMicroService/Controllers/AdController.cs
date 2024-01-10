using AdsMicroService.Models;
using AdsMicroService.Service;
using Microsoft.AspNetCore.Mvc;

namespace AdsMicroService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdController : BaseController<Ad>
    {
        public AdController(ILogger<BaseController<Ad>> logger, IRepository<Ad> _repo) : base(logger, _repo)
        {
        }
    }
}
