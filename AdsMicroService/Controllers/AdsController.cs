using AdsMicroService.Models;
using AdsMicroService.Service;
using Microsoft.AspNetCore.Mvc;

namespace AdsMicroService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdsController : BaseController<Ad>
    {
        public AdsController(ILogger<BaseController<Ad>> logger, IRepository<Ad> _repo) : base(logger, _repo)
        {
        }
    }
}
