using Warehouse_operationsApp.Models;

namespace Warehouse_operationsApp.Repository.Interfaces
{
    public interface IUsersRepository
    {
        ICollection<Users> GetUsersList();
        Users GetUsersById(int User_id);
        ICollection<Users> GetDoljnostiByUsers(int Id_doljnosti);
        bool UsersExists(int User_id);
    }
}
