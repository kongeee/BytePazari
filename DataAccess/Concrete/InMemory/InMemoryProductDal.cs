using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory {


    public class InMemoryProductDal : IProductDal {

        List<Product> _products;

        public InMemoryProductDal() {
            _products = new List<Product> {
                new Product{ProductId=1, Name="Urun1", BrandId=1, Price=5000, Stock=17},
                new Product{ProductId=2, Name="Urun2", BrandId=2, Price=4000, Stock=5},
                new Product{ProductId=3, Name="Urun3", BrandId=2, Price=9000, Stock=7},
                new Product{ProductId=4, Name="Urun4", BrandId=3, Price=7000, Stock=117},
                new Product{ProductId=5, Name="Urun5", BrandId=3, Price=2000, Stock=1},

            };
        }

        public void Add(Product product) {
            _products.Add(product);
        }

        public void Delete(Product product) {
            //LINQ
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            
            
            _products.Remove(productToDelete);
        }

        public Product Get() {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter) {
            throw new NotImplementedException();
        }

        public List<Product> GetAll() {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null) {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByBrandId(int brandId) {
            return _products.Where(p => p.BrandId == brandId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails() {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails(int productId) {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetailsById(int productId) {
            throw new NotImplementedException();
        }

        public void Update(Product product) {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.Name = product.Name;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.Price = product.Price;
            productToUpdate.Stock = product.Stock;
        }
    }
}
