using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

//this ConsoleUI project is created to test the data
namespace ConsoleUI {
    class Program {
        static void Main(string[] args) {
            ProductTest();

            //BrandTest();

        }

        private static void BrandTest() {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data) {
                Console.WriteLine(brand.Name);
            }

            var getBrandById = brandManager.Get(1).Data;
            Console.WriteLine(getBrandById.Name);
        }

        private static void ProductTest() {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails().Data) {
                Console.WriteLine(product.BrandName + product.Price);
            }
        }
    }
}
