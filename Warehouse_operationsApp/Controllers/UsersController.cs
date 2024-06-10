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
    public class UsersController: Controller
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMapper _mapper;

        public UsersController(IUsersRepository usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Users>))]
        public IActionResult GetUsersList()
        {
            var UsersList = _mapper.Map<List<UsersDto>>(_usersRepository.GetUsersList());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(UsersList);
        }

        [HttpGet("{UsersId}")]
        [ProducesResponseType(200, Type = typeof(Users))]
        [ProducesResponseType(400)]

        public IActionResult GetUsersById(int UsersId)
        {
            if (!_usersRepository.UsersExists(UsersId))
                return NotFound();

            var UsersById = _mapper.Map<UsersDto>(_usersRepository.GetUsersById(UsersId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(UsersById);
        }

        [HttpGet("Doljnosti/{Users}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Users>))]
        [ProducesResponseType(400)]

        public IActionResult GetDoljnostiByUsers(int id_doljnosti)
        {
            var doljnostiByUser = _mapper.Map<List<UsersDto>>(_usersRepository.GetDoljnostiByUsers(id_doljnosti));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(doljnostiByUser);
        }
    }
}
