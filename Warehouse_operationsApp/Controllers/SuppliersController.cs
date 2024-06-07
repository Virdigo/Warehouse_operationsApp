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
    public class SuppliersController : Controller
    {
        private readonly ISuppliersRepository _suppliersRepository;
        private readonly IMapper _mapper;

        public SuppliersController(ISuppliersRepository suppliersRepository, IMapper mapper)
        {
            _suppliersRepository = suppliersRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Suppliers>))]
        public IActionResult GetSuppliersList()
        {
            var supplier = _mapper.Map<List<SuppliersDto>>(_suppliersRepository.GetSuppliersList());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(supplier);
        }

        [HttpGet("{suppliersId}")]
        [ProducesResponseType(200, Type = typeof(Suppliers))]
        [ProducesResponseType(400)]

        public IActionResult GetSuppliersByID(int suppliersId)
        {
            if (!_suppliersRepository.SuppliersExists(suppliersId))
                return NotFound();

            var supplier = _mapper.Map<SuppliersDto>(_suppliersRepository.GetSuppliersById(suppliersId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(supplier);
        }

        [HttpGet("/Information_about_documents/{id_inf_doc}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(Suppliers))]
        
        public IActionResult GetSuppliersOfInformation_about_documents(int id_inf_doc)
        {
            var Suppl = _mapper.Map<SuppliersDto>(
                _suppliersRepository.GetSuppliersByInformation_about_documents(id_inf_doc));

            if (!ModelState.IsValid) return BadRequest();

            return Ok(Suppl);
        }
    }
}
