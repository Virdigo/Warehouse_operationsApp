using Warehouse_operationsApp.Models;

namespace Warehouse_operationsApp.Repository.Interfaces
{
    public interface IWarehousesRepository
    {
        ICollection<Warehouses> GetWarehousesList();
        Warehouses GetWarehousesById(int WarehousesId);
        ICollection<Warehouses> GetUsersByWarehouses(int User_id);
        bool WarehousesExists(int WarehousesId);
    }
}
