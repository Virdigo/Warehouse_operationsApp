using Warehouse_operationsApp.Models;

namespace Warehouse_operationsApp.Repository.Interfaces
{
    public interface IInformation_about_documentsRepository
    {
        ICollection<Information_about_documents> GetInformation_About_DocumentssList();
        Information_about_documents GetInformation_About_DocumentssById(int id_inf);
        ICollection<Information_about_documents> GetInformation_About_DocumentssByProduct(int ProductID);
        bool Information_about_documentsExists(int id_inf);
    }
}
