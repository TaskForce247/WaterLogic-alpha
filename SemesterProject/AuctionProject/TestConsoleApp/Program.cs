using BussinessLayer;
using Core;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
   public class Program
    {
        static void Main(string[] args)
        {
            ProductControler controller = new ProductControler();
          
           
            //var products = controller.GetProductsWithName("kola");
            //var auctions = Contrl.getAllAucionsForProducts(products.ToArray());
            var products = controller.GetProductsWithName("bike").ToArray();

           

        }
    }
}
