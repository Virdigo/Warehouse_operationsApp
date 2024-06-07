using AutoMapper;
using Warehouse_operationsApp.Data;
using Warehouse_operationsApp.Models;
using Warehouse_operationsApp.Repository.Interfaces;

namespace Warehouse_operationsApp.Repository
{
    public class Information_about_documentsRepository : IInformation_about_documentsRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public Information_about_documentsRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ICollection<Information_about_documents> GetInformation_About_DocumentssList()
        {
            return _context.Information_About_Documentss.ToList();
        }

        public Information_about_documents GetInformation_About_DocumentssById(int id_inf)
        {
            return _context.Information_About_Documentss.Where(r => r.id_inf_doc == id_inf).FirstOrDefault();
        }

        public ICollection<Information_about_documents> GetInformation_About_DocumentssByProduct(int ProductID)
        {
            return _context.Information_About_Documentss.Where(r => r.Product.id_Product == ProductID).ToList();
        }

        public bool Information_about_documentsExists(int id_inf_doc)
        {
            return _context.Information_About_Documentss.Any(r => r.id_inf_doc == id_inf_doc);
        }
    }
}
