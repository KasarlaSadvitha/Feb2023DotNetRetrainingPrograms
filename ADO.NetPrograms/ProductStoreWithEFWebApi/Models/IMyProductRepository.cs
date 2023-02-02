using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductStoreWithEFWebApi.Models
{
    internal interface IMyProductRepository
    {
       // interfaces cannot have instance fields
        IEnumerable<MyProduct> getAllProducts();
        MyProduct GetProductById(int productId);
        MyProduct GetProductByName(string productName);

      //  Task<MyProduct> GetProductWithHighPrice();
        MyProduct CreateProduct(MyProduct product);
        void DeleteProduct (int productId);
        MyProduct UpdateWithNewPrice(int newprice, int id);
       
        

        

    }
}
