using System.Diagnostics.Metrics;
using Warehouse_operationsApp.Data;
using Warehouse_operationsApp.Models;

namespace Warehouse_operationsApp
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {

            //// Проверка, есть ли данные в таблице Product_type
            //if (dataContext.Product_Types.Any())
            //{
            //    return; // Данные уже инициализированы
            //}

            //// Добавьте необходимые типы продуктов
            //dataContext.Product_Types.AddRange(
            //    new Product_type { Name = "Еда" },
            //    new Product_type { Name = "Одежда" },
            //    new Product_type { Name = "Электроника" }
            //);

            //// Добавьте необходимые единицы измерения
            //dataContext.Units.AddRange(
            //    new Unit { Name = "Штука" },
            //    new Unit { Name = "Килограмм" },
            //    new Unit { Name = "Литра" }
            //);

            //// Добавьте поставщиков
            //dataContext.Supplierss.AddRange(
            //    new Suppliers { Name = "Поставщик 1", Contact_Information = "Контактная информация 1" },
            //    new Suppliers { Name = "Поставщик 2", Contact_Information = "Контактная информация 2" }
            //);

            //// Добавьте должности
            //dataContext.Doljnostis.AddRange(
            //    new Doljnosti { Post = "Менеджер" },
            //    new Doljnosti { Post = "Складовщик" },
            //    new Doljnosti {  Post = "Продавец" }
            //);

            //// Добавьте пользователей
            //dataContext.Userss.AddRange(
            //    new Users { FIO = "Иван Иванов", Login = "ivanivanov", password = "password123", id_doljnosti = 1 }, // Менеджер
            //    new Users { FIO = "Петр Петров", Login = "petrpetrov", password = "password456", id_doljnosti = 2 }, // Складовщик
            //    new Users { FIO = "Анна Сидорова", Login = "annasily", password = "password789", id_doljnosti = 3 } // Продавец
            //);

            //// Добавьте склады
            //dataContext.Warehousess.AddRange(
            //    new Warehouses { Name = "Склад 1", address = "Адрес склада 1", id_users = 2 }, // Складовщик
            //    new Warehouses { Name = "Склад 2", address = "Адрес склада 2", id_users = 2 } // Складовщик
            //);

            //// Добавьте продукты
            //dataContext.Products.AddRange(
            //    new Product { Name = "Продукт 1", vendor_code = "123456", Price = 100, id_product_type = 1, id_unit = 1 }, // Еда, Штука
            //    new Product { Name = "Продукт 2", vendor_code = "789012", Price = 50, id_product_type = 2, id_unit = 2 }, // Одежда, Килограмм
            //    new Product { Name = "Продукт 3", vendor_code = "345678", Price = 200, id_product_type = 3, id_unit = 3 } // Электроника, Литра
            //);

            //// Добавьте документы
            //dataContext.Receipt_And_Expense_Documentss.AddRange(
            //    new Receipt_and_expense_documents { date = DateTime.Now, ReceiptAndexpense_documents = true, id_users = 1 }, // Приход, Менеджер
            //    new Receipt_and_expense_documents { date = DateTime.Now, ReceiptAndexpense_documents = false, id_users = 3 } // Расход, Продавец
            //);

            //// Добавьте информацию о документах
            //dataContext.Information_About_Documentss.AddRange(
            //    new Information_about_documents { id_Product = 1, Quanity = 10, id_doc = 1, id_suppliers = 1, Cost = 80, Price = 100 }, // Продукт 1, Приход, Поставщик 1
            //    new Information_about_documents { id_Product = 2, Quanity = 5, id_doc = 2, id_suppliers = 2, Cost = 40, Price = 50 } // Продукт 2, Расход, Поставщик 2
            //);

            //// Добавьте остатки
            //dataContext.Ostatkis.AddRange(
            //    new Ostatki { id_warehouses = 1, id_Product = 1, Quantity_Ostatki = 5 }, // Склад 1, Продукт 1, 5 штук
            //    new Ostatki { id_warehouses = 2, id_Product = 2, Quantity_Ostatki = 2 } // Склад 2, Продукт 2, 2 килограмма
            //);

            //// Сохраните изменения в базе данных
            //dataContext.SaveChanges();
        }


    }
}