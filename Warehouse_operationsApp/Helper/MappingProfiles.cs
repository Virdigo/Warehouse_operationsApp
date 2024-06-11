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
            CreateMap<Ostatki, OstatkiDto>();
            CreateMap<Product, ProductsDto>();
            CreateMap<Users, UsersDto>();
            CreateMap<Warehouses, WarehousesDto>();
            CreateMap<DoljnostiDto, Doljnosti>();
            CreateMap<SuppliersDto, Suppliers>();
            CreateMap<Information_about_documentsDto, Information_about_documents>();
            CreateMap<OstatkiDto, Ostatki>();
            CreateMap<Product_typeDto, Product_type>();
            CreateMap<ProductsDto, Product>();
            CreateMap<Receipt_and_expense_documentsDto, Receipt_and_expense_documents>();
        }
    }
}
