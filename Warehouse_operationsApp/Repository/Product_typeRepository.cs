using AutoMapper;
using Warehouse_operationsApp.Data;
using Warehouse_operationsApp.Models;
using Warehouse_operationsApp.Repository.Interfaces;

namespace Warehouse_operationsApp.Repository
{
    public class Product_typeRepository : IProduct_typeRepository
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public Product_typeRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ICollection<Product> GetProductsByProduct_type(int Id_product_type)
        {
            return _context.Products.Where(c => c.Product_type.id_product_type == Id_product_type).ToList();
        }

        public Product_type GetProductTypeById(int id)
        {
            return _context.Product_Types.Where(e => e.id_product_type == id).FirstOrDefault();
        }

        public ICollection<Product_type> GetProductTypesList()
        {
            return _context.Product_Types.ToList();
        }

        public bool Product_typeExists(int id)
        {
            return _context.Product_Types.Any(c => c.id_product_type == id);
        }
    }
}
