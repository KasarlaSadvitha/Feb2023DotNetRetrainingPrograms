using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ProductStoreWithEFWebApi;
using ProductStoreWithEFWebApi.DataAccessLayer;

namespace ProductStoreWithEFWebApi.Models
{
    public class MyProductRepository : IMyProductRepository

    {
        MyProDAL dal = new MyProDAL();
        MyProductBusinessLayer bl = new MyProductBusinessLayer();
        public MyProduct CreateProduct(MyProduct product)
        {
            bl.SaveMyProduct(product);
            return product;
        }

        public void DeleteProduct(int productId)
        {
            MyProduct product = GetProductById(productId);
            bl.DeleteMyProduct(product);
        }

        public IEnumerable<MyProduct> getAllProducts()
        {
            return bl.ProductsList();
        }

        public MyProduct GetProductById(int productId)
        {
            var pro = dal.MyProducts.Find(productId);
          // MyProduct product =  bl.ProductsList().Find(p=>p.Id == productId);
            return pro;
        }

        public MyProduct GetProductByName(string productName)
        {
            MyProduct product = bl.ProductsList().Find(p => p.Name == productName);
            return product;
        }

        public MyProduct UpdateWithNewPrice(int newprice ,int id)
        {
            
          MyProduct p2=  bl.Update(id, newprice);
            return p2;

        }
        //public task<myproduct> getproductwithhighprice()
        //{
        //    myproduct product = bl.productslist().find(p=>p.)
        //}
    }
}