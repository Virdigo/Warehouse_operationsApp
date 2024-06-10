using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Warehouse_operationsApp.Dto;
using Warehouse_operationsApp.Models;
using Warehouse_operationsApp.Repository;
using Warehouse_operationsApp.Repository.Interfaces;

namespace Warehouse_operationsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Product>))]
        public IActionResult GetProductsList()
        {
            var ProductList = _mapper.Map<List<ProductsDto>>(_productRepository.GetProductsList());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(ProductList);
        }

        [HttpGet("{ProductId}")]
        [ProducesResponseType(200, Type = typeof(Product))]
        [ProducesResponseType(400)]

        public IActionResult GetProductById(int ProductId)
        {
            if (!_productRepository.ProductExists(ProductId))
                return NotFound();

            var ProductById = _mapper.Map<ProductsDto>(_productRepository.GetProductById(ProductId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(ProductById);
        }

        [HttpGet("Ostatki/{product}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Product>))]
        [ProducesResponseType(400)]

        public IActionResult GetInformation_about_documentsByProduct(int id_inf)
        {
            var InfProduct = _mapper.Map<List<ProductsDto>>(_productRepository.GetInformation_about_documentsByProduct(id_inf));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(InfProduct);
        }
    }
}
