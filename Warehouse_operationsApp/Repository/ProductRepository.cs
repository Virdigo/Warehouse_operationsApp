using Warehouse_operationsApp.Data;
using Warehouse_operationsApp.Models;
using Warehouse_operationsApp.Repository.Interfaces;

namespace Warehouse_operationsApp.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Product> GetInformation_about_documentsByProduct(int id_inf)
        {
            return _context.Products.Where(r => r.id_Product == id_inf).ToList();
        }

        public Product GetProductById(int ProductId)
        {
            return _context.Products.Where(r => r.id_Product == ProductId).FirstOrDefault();
        }

        public ICollection<Product> GetProductsList()
        {
            return _context.Products.ToList();
        }

        public bool ProductExists(int ProductId)
        {
            return _context.Products.Any(r => r.id_Product == ProductId);
        }
    }
}
