using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataBase
{


    class Program
    {
        static void Main(string[] args)
        {
            using (ProdContext db = new ProdContext())
            {
                // Create and save a new Blog
                //Console.Write("Enter a name for a new Category: ");
                //String cat_name = Console.ReadLine();

                //Category category = new Category { Name = cat_name };
                //db.Categories.Add(category);
                //db.SaveChanges();

                          var query = from c in db.Categories
                            orderby c.Name descending
                            select c.Name;

                foreach (var cat in query)
                {
                    Console.WriteLine("----" + cat);
                };

                showCategories(db);
                showProductsWithCategories(db);
                showCategoriesWithAmout(db);
                showCategoriesWithAmout2(db);


                //OrderHistoryForm orderHistoryForm = new OrderHistoryForm();
                //orderHistoryForm.ShowDialog();
                CategoryForm categoryForm = new CategoryForm();
                categoryForm.ShowDialog();
                //AddCategoryForm addCat = new AddCategoryForm();
                //addCat.ShowDialog();
                //AddOrderForm addOrderForm = new AddOrderForm();
                //addOrderForm.ShowDialog();

                //AddCustomer addCustomer = new AddCustomer();
                //addCustomer.ShowDialog();

            }
        }

        private static void showCategories(ProdContext context)
        {

            var query = context.Categories.Select(c => c.Name).ToList();

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }


        private static void showProductsWithCategories(ProdContext context)
        {
            var query = from product in context.Products
                        join category in context.Categories
                        on product.CategoryID equals category.CategoryID
                        select new
                        {
                            CategoryId = category.CategoryID,
                            CategoryName = category.Name,
                            ProductId = product.ProductId,
                            ProductName = product.Name,
                            Unitprice = product.UnitPrice,
                            UnitsInStock = product.UnitsInStock
                        };

            foreach(var item in query)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                    item.CategoryId,
                    item.CategoryName,
                    item.ProductId,
                    item.ProductName,
                    item.Unitprice,
                    item.UnitsInStock
                    );
            }
        
        }


        private static void showProductsWithCategories2(ProdContext context)
        {
            var query = context.Categories.Join(context.Products, category => category.CategoryID, product => product.CategoryID,
                (category, product) => new
                {
                    CategoryId = category.CategoryID,
                    CategoryName = category.Name,
                    ProductId = product.ProductId,
                    ProductName = product.Name,
                    Unitprice = product.UnitPrice,
                    UnitsInStock = product.UnitsInStock
                });
                          
            foreach (var item in query)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                    item.CategoryId,
                    item.CategoryName,
                    item.ProductId,
                    item.ProductName,
                    item.Unitprice,
                    item.UnitsInStock
                    );
            }
        }


        private static void showCategoriesWithAmout(ProdContext context)
        {
            var query = from category in context.Categories
                        join product in context.Products
                        on category.CategoryID equals product.CategoryID
                        into categorygroup
                        select new
                        {
                            Category = category.CategoryID,
                            Ammount = categorygroup.Count()
                        };
            foreach (var item in query)
            {
                Console.WriteLine(item);

            }
        }

        private static void showCategoriesWithAmout2(ProdContext context)
        {
            var query = context.Categories.GroupJoin(context.Products,
                category => category.CategoryID, product => product.CategoryID,
                (category, categoryGroup) => new
                {
                    Category = category.CategoryID,
                    Ammout = categoryGroup.Count()
                });

            foreach(var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
