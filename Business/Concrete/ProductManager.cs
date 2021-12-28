using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;



namespace Business.Concrete {
    public class ProductManager : IProductService {

        IProductDal _productDal;

        public ProductManager(IProductDal productDal) {
            _productDal = productDal;
        }

        public IDataResult<Product> Get(int productId) {
            return new SuccessDataResult<Product>( _productDal.Get(p => p.ProductId == productId), Messages.Smsg);
        }

        public IDataResult<List<Product>> GetAll() {

            

            return new SuccessDataResult<List<Product>> (_productDal.GetAll(), Messages.Smsg);

        }

        public IDataResult<List<Product>> GetAllByBrandId(int brandId) {
            return new SuccessDataResult<List<Product>> (_productDal.GetAll(p => p.BrandId == brandId), Messages.Smsg);
        }

        public IDataResult<List<Product>> GetAllByPrice(int min, int max) {
            return new SuccessDataResult<List<Product>>( _productDal.GetAll(p => p.Price >= min && p.Price <= max), Messages.Smsg);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetailsById(int productId) {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetailsById(productId), Messages.Smsg);
        }
        public IDataResult<List<ProductDetailDto>> GetProductDetails() {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails(), Messages.Smsg);
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product) {
            _productDal.Add(product);
            return new SuccessResult(Messages.Smsg);
        }
        public IResult Update(Product product) {
            _productDal.Update(product);
            return new SuccessResult(Messages.Smsg);
        }
        public IResult Delete(Product product) {
            _productDal.Delete(product);
            return new SuccessResult(Messages.Smsg);
        }
    }
}
