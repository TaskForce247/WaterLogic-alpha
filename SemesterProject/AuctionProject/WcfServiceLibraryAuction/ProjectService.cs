using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Core;
using BussinessLayer;
using System.Collections.ObjectModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace WcfServiceLibrary
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    [GlobalErrorBehavior(typeof(ErrorHandler))]
    class ProjectService : IProjectService
    {
        public static void Main(string[] args)
        {
            using (ServiceHost serviceHost = new ServiceHost(typeof(ProjectService)))
            {
                try
                {
                    // Open the ServiceHost to start listening for messages.
                    serviceHost.Open();
                    //session behavior default: Per session-allocate a service instance for each client connection;
                    //per call/per instance
                    //Isolation level-Read Commited

                    // The service can now be accessed.
                    Console.WriteLine("The service is ready.");
                    Console.WriteLine("Press <ENTER> to terminate service.");
                    Console.ReadLine();

                    // Close the ServiceHost.
                    serviceHost.Close();
                }
                catch (TimeoutException timeProblem)
                {
                    Console.WriteLine(timeProblem.Message);
                    Console.ReadLine();
                }
                catch (CommunicationException commProblem)
                {
                    Console.WriteLine(commProblem.Message);
                    Console.ReadLine();
                }catch(Exception)
                {
                    Console.Write("exception");
                }

            }
        }

        public void LogError(Exception e)
        {
            ErrorHandler handler = new ErrorHandler();
            handler.HandleError(e);
        }
        #region Account
        AccountController contr = new AccountController();
        public int AddAccount(Account Account)
        {
                return contr.Add(Account);
        }

        public Account GetAccountById(int Id)
        {

            return contr.getById(Id);
        }

        public ICollection<Account> GetAllAccounts()
        {

            return contr.getAll();
        }

        public void RemoveAccount(Account Account)
        {

            contr.Remove(Account);
        }

        public int RemoveAccountById(int Id)
        {

            return contr.RemoveById(Id);
        }

        public int UpdateAccount(Account Account)
        {

            return contr.Update(Account);
        }
        public Account GetAccountByUsername(string username)
        {

            return contr.GetAccountByUsername(username);
        }

        public Account GetAccountByEmail(string email)
        {

            return contr.GetAccountByEmail(email);
        }

        public Account GetAccountWithObjects(int Id)
        {
            return contr.GetByIdWithObjects(Id);
        }

        public Account HashAndSaltPassword(Account acc)
        {
            return contr.HashAndSaltPassword(acc);
        }

        public bool Login(Account acc, string password)
        {
            return contr.Login(acc, password);
        }
        #endregion

       

        #region Category
        CategoryController CategoryCtrl = new CategoryController();
        public int AddCategory(Category Category)
        {
            return CategoryCtrl.Add(Category);
        }

        public ICollection<Category> GetAllCategories()
        {
            return CategoryCtrl.getAll();
        }

        public Category GetCategoryByName(string name)
        {
            return CategoryCtrl.GetCategoryByName(name);
        }

        public Category GetCategorytById(int Id)
        {
            return CategoryCtrl.getById(Id);
        }

        public Category GetCategoryWithObjects(int Id)
        {
            return CategoryCtrl.GetByIdWithObjects(Id);
        }

        public void RemoveCategory(Category Category)
        {
            CategoryCtrl.Remove(Category);
        }

        public int RemoveCategoryById(int Id)
        {
            return CategoryCtrl.RemoveById(Id);
        }

        public int RemoveCategoryByName(string name)
        {
            return CategoryCtrl.RemoveCategoryByName(name);
        }

        public int UpdateCategory(Category Category)
        {
            return CategoryCtrl.Update(Category);
        }
        #endregion

        #region Product
        ProductControler ProductContrl = new ProductControler();
        public int AddProduct(Product Product)
        {
            return ProductContrl.Add(Product);
        }

        public IEnumerable<Product> GetAllProductsInCategory(int CategoryId)
        {
            return ProductContrl.GetAllProductsInCategory(CategoryId);
        }

        public IEnumerable<Product> FindProductsWithPriceLessThan(double price)
        {
            return ProductContrl.FindProductsWithPriceLessThan(price);
        }

        public IEnumerable<Product> FindProductsWithPriceMoreThan(double price)
        {
            return ProductContrl.FindProductsWithPriceLessThan(price);
        }

        public ICollection<Product> GetAllProducts()
        {
            return ProductContrl.getAll();
        }

        public Product GetProductById(int Id)
        {
            return ProductContrl.getById(Id);
        }

        public IEnumerable<Product> GetProductsWithDescription(string description)
        {
            return ProductContrl.GetProductsWithDescription(description);
        }

        public IEnumerable<Product> GetProductsWithName(string name)
        {
            return ProductContrl.GetProductsWithName(name);
        }

        public Product GetProductWithObjects(int Id)
        {
            return ProductContrl.GetByIdWithObjects(Id);
        }

        public void RemoveProduct(Product Product)
        {
            ProductContrl.Remove(Product);
        }

        public int RemoveProductById(int Id)
        {
            return ProductContrl.RemoveById(Id);
        }

        public int UpdateProduct(Product Product)
        {
            return ProductContrl.Update(Product);
        }
        #endregion
    }
    
}
