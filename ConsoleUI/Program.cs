using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             ProductTest();

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            Console.WriteLine("Kategoriler Listeleniyor!");

            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager prodcutManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal));
            Console.WriteLine("Ürünler Listeleniyor!");
            var result = prodcutManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}