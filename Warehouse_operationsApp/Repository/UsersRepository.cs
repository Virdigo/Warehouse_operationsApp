using AutoMapper;
using Warehouse_operationsApp.Data;
using Warehouse_operationsApp.Models;
using Warehouse_operationsApp.Repository.Interfaces;

namespace Warehouse_operationsApp.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UsersRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ICollection<Users> GetDoljnostiByUsers(int Id_doljnosti)
        {
            return _context.Userss.Where(r => r.Doljnosti.id_doljnosti == Id_doljnosti).ToList();
        }

        public Users GetUsersById(int User_id)
        {
            return _context.Userss.Where(r => r.id_users == User_id).FirstOrDefault();
        }

        public ICollection<Users> GetUsersList()
        {
            return _context.Userss.ToList();
        }

        public bool UsersExists(int User_id)
        {
            return _context.Userss.Any(r => r.id_users == User_id);
        }
    }
}
