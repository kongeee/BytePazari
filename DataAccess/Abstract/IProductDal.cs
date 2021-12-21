using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract {
    public interface IProductDal {
        Product Get();
        List<Product> GetAll();
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<Product> GetAllByBrandId(int brandId);


    }
}
