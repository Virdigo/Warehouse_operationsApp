using Warehouse_operationsApp.Models;

namespace Warehouse_operationsApp.Repository.Interfaces
{
    public interface IProductRepository
    {
        ICollection<Product> GetProductsList();
        Product GetProductById(int ProductId);
        ICollection<Product> GetInformation_about_documentsByProduct(int id_inf);
        bool ProductExists(int ProductId);
    }
}
