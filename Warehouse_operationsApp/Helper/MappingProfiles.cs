using AutoMapper;
using Warehouse_operationsApp.Dto;
using Warehouse_operationsApp.Models;

namespace Warehouse_operationsApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Doljnosti, DoljnostiDto>();
            CreateMap<Product_type, Product_typeDto>();
            CreateMap<Suppliers, SuppliersDto>();
            CreateMap<Receipt_and_expense_documents, Receipt_and_expense_documentsDto>();
            CreateMap<Information_about_documents, Information_about_documentsDto>();
            CreateMap<Unit, UnitDto>();
            CreateMap<DoljnostiDto, Doljnosti>();
        }
    }
}
