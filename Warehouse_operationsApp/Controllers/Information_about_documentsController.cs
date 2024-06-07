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
    public class Information_about_documentsController : Controller
    {
        private readonly IInformation_about_documentsRepository _information_About_DocumentsRepository;
        private readonly IMapper _mapper;

        public Information_about_documentsController(IInformation_about_documentsRepository information_about_documentsRepository, IMapper mapper)
        {
            _information_About_DocumentsRepository = information_about_documentsRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Information_about_documents>))]
        public IActionResult GetInformation_about_documentsList()
        {
            var Information_about_documents = _mapper.Map<List<Information_about_documentsDto>>(_information_About_DocumentsRepository.GetInformation_About_DocumentssList());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(Information_about_documents);
        }

        [HttpGet("{id_inf}")]
        [ProducesResponseType(200, Type = typeof(Information_about_documents))]
        [ProducesResponseType(400)]

        public IActionResult GetProductTypeByID(int id_inf)
        {
            if (!_information_About_DocumentsRepository.Information_about_documentsExists(id_inf))
                return NotFound();

            var Information_about_documents = _mapper.Map<Information_about_documentsDto>(_information_About_DocumentsRepository.GetInformation_About_DocumentssById(id_inf));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(Information_about_documents);
        }

        [HttpGet("Information_about_documents/{product}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Information_about_documents>))]
        [ProducesResponseType(400)]

        public IActionResult GetInformation_About_DocumentssByProduct(int product)
        {
            var producttos = _mapper.Map<List<Product_typeDto>>(_information_About_DocumentsRepository.GetInformation_About_DocumentssById(product));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(producttos);
        }
    }
}
