using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;



namespace Business.Concrete {
    public class ProductManager : IProductService {

        IProductDal _productDal;

        public ProductManager(IProductDal productDal) {
            _productDal = productDal;
        }

        public List<Product> GetAll() {
            return _productDal.GetAll();

        }

        public List<Product> GetAllByBrandId(int brandId) {
            return _productDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Product> GetAllByPrice(int min, int max) {
            return _productDal.GetAll(p => p.Price >= min && p.Price <= max);
        }
    }
}
