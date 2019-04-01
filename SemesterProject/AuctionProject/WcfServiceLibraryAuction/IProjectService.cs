using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Core;
namespace WcfServiceLibrary
{
    [ServiceContract]
    interface IProjectService
    {
        [OperationContract]
        void LogError(Exception e);

        #region AccountService
        [OperationContract]
        Account GetAccountById(int Id);

        [OperationContract]
        Account HashAndSaltPassword(Account acc);

        [OperationContract]
        bool Login(Account acc, string password);
       

        [OperationContract]
        int AddAccount(Account Account);

        [OperationContract]
        ICollection<Account> GetAllAccounts();// has add,copy compard to IEnumerable which doesnt have it

        [OperationContract]
        void RemoveAccount(Account Account);

        [OperationContract]
        int RemoveAccountById(int Id);

        [OperationContract]
        int UpdateAccount(Account Account);
        [OperationContract]
        Account GetAccountByUsername(string username);
        [OperationContract]
        Account GetAccountByEmail(string email);
        [OperationContract]
        Account GetAccountWithObjects(int Id);

        #endregion

      

        #region CategoryService
        [OperationContract]
        Category GetCategorytById(int Id);

        [OperationContract]
        int AddCategory(Category Category);

        [OperationContract]
        ICollection<Category> GetAllCategories();

        [OperationContract]
        void RemoveCategory(Category Category);

        [OperationContract]
        int RemoveCategoryById(int Id);

        [OperationContract]
        int UpdateCategory(Category Category);

        [OperationContract]
        Category GetCategoryByName(string name);
        [OperationContract]
        int RemoveCategoryByName(string name);
        [OperationContract]
        Category GetCategoryWithObjects(int Id);
        #endregion

      

        #region ProductService

        [OperationContract]
        Product GetProductById(int Id);

        [OperationContract]
        IEnumerable<Product> GetAllProductsInCategory(int CategoryId);

        [OperationContract]
        int AddProduct(Product Product);

        [OperationContract]
        ICollection<Product> GetAllProducts();

        [OperationContract]
        void RemoveProduct(Product Product);

        [OperationContract]
        int RemoveProductById(int Id);

        [OperationContract]
        int UpdateProduct(Product Product);

        [OperationContract]
        IEnumerable<Product> FindProductsWithPriceMoreThan(double price);

        [OperationContract]
        IEnumerable<Product> GetProductsWithName(string name);

        [OperationContract]
        IEnumerable<Product> GetProductsWithDescription(string description);

        [OperationContract]
        IEnumerable<Product> FindProductsWithPriceLessThan(double price);
        [OperationContract]
        Product GetProductWithObjects(int Id);
        #endregion
    }

}
