using AdsMicroService.Service;
using Microsoft.AspNetCore.Mvc;

namespace AdsMicroService.Controllers
{
    public abstract class BaseController<T> : Controller where T : class
    {
        private readonly IRepository<T> _repo;
        private readonly ILogger<BaseController<T>> _logger;

        public BaseController(ILogger<BaseController<T>> logger, IRepository<T> repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _repo.GetById(id);
        }

        [HttpGet]
        public IReadOnlyCollection<T> GetAll()
        {
            return _repo.GetProducts();
        }
    }
}
