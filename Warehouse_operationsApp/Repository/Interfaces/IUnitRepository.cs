using Warehouse_operationsApp.Models;

namespace Warehouse_operationsApp.Repository.Interfaces
{
    public interface IUnitRepository
    {
        ICollection<Unit> GetUnitsList();
        Unit GetUnitsById(int idUnit);
        ICollection<Unit> GetUnitsByProduct(int ProductID);
        bool UnitExists(int idUnit);
    }
}
