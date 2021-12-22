using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


//deneme yorumu-ekici-görkem-son-civan
namespace Business.Concrete {
    public class ProductManager : IProductService {

        IProductDal _productDal;

        public ProductManager(IProductDal productDal) {
            _productDal = productDal;
        }

        public List<Product> GetAll() {
            return _productDal.GetAll();

        }
    }
}
