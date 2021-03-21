using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;// = new List<Product>();
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{CategoryId=1,ProductId=1,ProductName="laptop",UnitPrice=15,UnitsInStock=22},
                new Product{CategoryId=2,ProductId=2,ProductName="bardak",UnitPrice=500,UnitsInStock=32},
                new Product{CategoryId=3,ProductId=3,ProductName="laptop",UnitPrice=35,UnitsInStock=22},
                new Product{CategoryId=4,ProductId=4,ProductName="klavye",UnitPrice=45,UnitsInStock=2},
                new Product{CategoryId=5,ProductId=5,ProductName="telefon",UnitPrice=18,UnitsInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product deletedProduct = _products.Find(p => p.ProductId == product.ProductId);
            _products.Remove(deletedProduct);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
