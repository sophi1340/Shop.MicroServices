using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Products.Domain;
using Products.Domain.Products;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IReadUnitOfWork _readUnitOfWork;
        private readonly IMapper _mapper;

        public ProductsController(IReadUnitOfWork readUnitOfWork, IMapper mapper)
        {
            _readUnitOfWork = readUnitOfWork;
            _mapper = mapper;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<List<ProductResDto>> Get()
        {
            return _mapper.Map<List<ProductResDto>>(await _readUnitOfWork.ProductReadRepository.GetAllAsync());

        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
