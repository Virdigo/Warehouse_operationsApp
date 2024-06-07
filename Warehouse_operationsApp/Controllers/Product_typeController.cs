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
    public class Product_typeController : Controller
    {
        private readonly IProduct_typeRepository _product_TypeRepository;
        private readonly IMapper _mapper;

        public Product_typeController(IProduct_typeRepository product_typeRepository, IMapper mapper)
        {
            _product_TypeRepository = product_typeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Product_type>))]
        public IActionResult GetProduct_typeList()
        {
            var ProductTypes = _mapper.Map<List<Product_typeDto>>(_product_TypeRepository.GetProductTypesList());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(ProductTypes);
        }

        [HttpGet("{product_TypeId}")]
        [ProducesResponseType(200, Type = typeof(Product_type))]
        [ProducesResponseType(400)]

        public IActionResult GetProductTypeByID(int product_TypeId)
        {
            if (!_product_TypeRepository.Product_typeExists(product_TypeId))
                return NotFound();

            var product_Type = _mapper.Map<Product_typeDto>(_product_TypeRepository.GetProductTypeById(product_TypeId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(product_Type); 
        }

        [HttpGet("product/{product_TypeId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Product_type>))]
        [ProducesResponseType(400)]

        public IActionResult GetProductsByProduct_type(int product_TypeId)
        {
            var products = _product_TypeRepository.GetProductsByProduct_type(product_TypeId);
            var productDtos = _mapper.Map<List<Product_typeDto>>(products);

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(productDtos);
        }
    }
}
