using Warehouse_operationsApp.Models;

namespace Warehouse_operationsApp.Repository.Interfaces
{
    public interface IOstatkiRepository
    {
        ICollection<Ostatki> GetOstatkisList();
        Ostatki GetOstatkiById(int OstatkiId);
        ICollection<Ostatki> GetOstatkisOfProduct(int ProductId);
        bool OstatkiExists(int OstatkiId);  
    }
}
