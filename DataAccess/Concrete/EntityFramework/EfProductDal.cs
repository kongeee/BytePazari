using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework {
    public class EfProductDal : IProductDal {
		//
        public void Add(Product product) {
            throw new NotImplementedException();
        }

        public void Delete(Product product) {
            throw new NotImplementedException();
        }

        public Product Get() {
            throw new NotImplementedException();
        }

        public List<Product> GetAll() {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByBrandId(int brandId) {
            throw new NotImplementedException();
        }

        public void Update(Product product) {
            throw new NotImplementedException();
        }
    }
}
