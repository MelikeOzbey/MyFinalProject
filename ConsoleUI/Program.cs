using Business.Concrete;
using DataAccess.Concrete.EntiyFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.ComponentModel;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CategoryTest();
            ProductTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productmanager = new ProductManager(new EfProductDal());
            foreach (var product in productmanager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName+" "+product.CategoryName);
            };
        }
    }
}
