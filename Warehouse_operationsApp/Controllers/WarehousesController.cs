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
    public class WarehousesController : Controller
    {
        private readonly IWarehousesRepository _warehousesRepository;
        private readonly IMapper _mapper;

        public WarehousesController(IWarehousesRepository warehousesRepository, IMapper mapper)
        {
            _warehousesRepository = warehousesRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Warehouses>))]
        public IActionResult GetWarehousesList()
        {
            var WarehousesList = _mapper.Map<List<WarehousesDto>>(_warehousesRepository.GetWarehousesList());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(WarehousesList);
        }

        [HttpGet("{WarehousesId}")]
        [ProducesResponseType(200, Type = typeof(Warehouses))]
        [ProducesResponseType(400)]

        public IActionResult GetWarehousesById(int WarehousesId)
        {
            if (!_warehousesRepository.WarehousesExists(WarehousesId))
                return NotFound();

            var WarehousesById = _mapper.Map<WarehousesDto>(_warehousesRepository.GetWarehousesById(WarehousesId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(WarehousesById);
        }

        [HttpGet("Users/{Warehouses}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Warehouses>))]
        [ProducesResponseType(400)]

        public IActionResult GetUsersByWarehouses(int User_id)
        {
            var doljnostiByUser = _mapper.Map<List<WarehousesDto>>(_warehousesRepository.GetUsersByWarehouses(User_id));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(doljnostiByUser);
        }
    }
}
