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
    public class UnitController : Controller
    {
        private readonly IUnitRepository _unitRepository;
        private readonly IMapper _mapper;

        public UnitController(IUnitRepository unitRepository, IMapper mapper)
        {
            _unitRepository = unitRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Unit>))]
        public IActionResult GetUnitsList()
        {
            var unit = _mapper.Map<List<UnitDto>>(_unitRepository.GetUnitsList());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(unit);
        }

        [HttpGet("{UnitId}")]
        [ProducesResponseType(200, Type = typeof(Suppliers))]
        [ProducesResponseType(400)]

        public IActionResult GetSuppliersByID(int UnitId)
        {
            if (!_unitRepository.UnitExists(UnitId))
                return NotFound();

            var supplier = _mapper.Map<UnitDto>(_unitRepository.GetUnitsById(UnitId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(supplier);
        }

        [HttpGet("Unit/{product}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Unit>))]
        [ProducesResponseType(400)]

        public IActionResult GetUnitsByProduct(int product)
        {
            var Unitsss = _mapper.Map<List<UnitDto>>(_unitRepository.GetUnitsByProduct(product));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(Unitsss);
        }
    }
}
