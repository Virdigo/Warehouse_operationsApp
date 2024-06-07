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
    public class Receipt_and_expense_documentsController : Controller
    {
        private readonly IReceipt_and_expense_documentsRepository _receipt_And_Expense_DocumentsRepository;
        private readonly IMapper _mapper;

        public Receipt_and_expense_documentsController(IReceipt_and_expense_documentsRepository receipt_and_expense_documentsRepository, IMapper mapper)
        {
            _receipt_And_Expense_DocumentsRepository = receipt_and_expense_documentsRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Receipt_and_expense_documents>))]
        public IActionResult GetReceipt_and_expense_documentsList()
        {
            var Receipt_and_expense_doc = _mapper.Map<List<Receipt_and_expense_documentsDto>>(_receipt_And_Expense_DocumentsRepository.GetReceipt_and_expense_documentsList());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(Receipt_and_expense_doc);
        }

        [HttpGet("{GetReceipt_and_expense_documentsId}")]
        [ProducesResponseType(200, Type = typeof(Receipt_and_expense_documents))]
        [ProducesResponseType(400)]

        public IActionResult GetReceipt_and_expense_documentsByID(int GetReceipt_and_expense_documentsId)
        {
            if (!_receipt_And_Expense_DocumentsRepository.Receipt_and_expense_documentsExists(GetReceipt_and_expense_documentsId))
                return NotFound();

            var receiptAndExpenseDoc = _mapper.Map<Receipt_and_expense_documentsDto>(_receipt_And_Expense_DocumentsRepository.GetReceipt_and_expense_documentsById(GetReceipt_and_expense_documentsId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(receiptAndExpenseDoc);
        }
        [HttpGet("{GetReceipt_and_expense_documentsId}/Information_about_documents")]
        [ProducesResponseType(200, Type = typeof(Information_about_documents))]
        [ProducesResponseType(400)]

        public IActionResult GetInformation_about_documentsByReceipt_and_expense_documents(int GetReceipt_and_expense_documentsId)
        {
            if (!_receipt_And_Expense_DocumentsRepository.Receipt_and_expense_documentsExists(GetReceipt_and_expense_documentsId))
                return NotFound();

            var inf = _mapper.Map<List<Information_about_documentsDto>>(_receipt_And_Expense_DocumentsRepository.Receipt_and_expense_documentsExists(GetReceipt_and_expense_documentsId));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(inf);
        }
    }
}
