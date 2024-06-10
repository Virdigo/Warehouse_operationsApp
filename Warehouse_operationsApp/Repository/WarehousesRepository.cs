using AutoMapper;
using Warehouse_operationsApp.Data;
using Warehouse_operationsApp.Models;
using Warehouse_operationsApp.Repository.Interfaces;

namespace Warehouse_operationsApp.Repository
{
    public class WarehousesRepository : IWarehousesRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public WarehousesRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ICollection<Warehouses> GetUsersByWarehouses(int User_id)
        {
            return _context.Warehousess.Where(r => r.Users.id_users == User_id).ToList();
        }

        public Warehouses GetWarehousesById(int WarehousesId)
        {
            return _context.Warehousess.Where(r => r.id_warehouses == WarehousesId).FirstOrDefault();
        }

        public ICollection<Warehouses> GetWarehousesList()
        {
            return _context.Warehousess.ToList();
        }

        public bool WarehousesExists(int WarehousesId)
        {
            return _context.Warehousess.Any(r => r.id_warehouses == WarehousesId);
        }
    }
}
