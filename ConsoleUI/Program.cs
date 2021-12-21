using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

//this ConsoleUI project is created to test the data
namespace ConsoleUI {
    class Program {
        static void Main(string[] args) {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            foreach (var product in productManager.GetAll()) {
                Console.WriteLine(product.Name);
            }
        }
    }
}
