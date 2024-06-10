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
    public class OstatkiController: Controller
    {
        private readonly IOstatkiRepository _ostatkiRepository;
        private readonly IMapper _mapper;

        public OstatkiController(IOstatkiRepository ostatkiRepository, IMapper mapper)
        {
            _ostatkiRepository = ostatkiRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Ostatki>))]
        public IActionResult GetOstatkisList()
        {
            var OstatkiList = _mapper.Map<List<OstatkiDto>>(_ostatkiRepository.GetOstatkisList());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(OstatkiList);
        }

        [HttpGet("{OstatkiId}")]
        [ProducesResponseType(200, Type = typeof(Ostatki))]
        [ProducesResponseType(400)]

        public IActionResult GetOstatkiById(int OstatkiId)
        {
            if (!_ostatkiRepository.OstatkiExists(OstatkiId))
                return NotFound();

            var OstatkiById = _mapper.Map<OstatkiDto>(_ostatkiRepository.GetOstatkiById(OstatkiId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(OstatkiById);
        }

        [HttpGet("Ostatki/{product}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Ostatki>))]
        [ProducesResponseType(400)]

        public IActionResult GetOstatkisOfProduct(int product)
        {
            var OstatkiProduct = _mapper.Map<List<OstatkiDto>>(_ostatkiRepository.GetOstatkiById(product));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(OstatkiProduct);
        }
    }
}
