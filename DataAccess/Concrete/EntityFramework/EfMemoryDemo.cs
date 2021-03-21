using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMemoryDemo : IProductDal
    {
        List<Product> _products;

        public EfMemoryDemo()
        {
            _products = new List<Product>()
            {
                new Product {CategoryId=2,ProductId=2,ProductName="Gardrop",UnitPrice=78,UnitsInStock=6},
                new Product {CategoryId=3,ProductId=2,ProductName="masa",UnitPrice=48,UnitsInStock=12},
                new Product {CategoryId=4,ProductId=3,ProductName="klima",UnitPrice=650,UnitsInStock=18}
            };
        }
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
