using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract {
    public interface IProductService {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByBrandId(int brandId);
        IDataResult<List<Product>> GetAllByPrice(int min, int max);
        IDataResult<Product> Get(int productId);
        

        IDataResult<List<ProductDetailDto>> GetProductDetailsById(int productId);
        IDataResult<List<ProductDetailDto>> GetProductDetails();

        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);

    }
}
