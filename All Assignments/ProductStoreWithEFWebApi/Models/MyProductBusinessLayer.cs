using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductStoreWithEFWebApi.DataAccessLayer;

namespace ProductStoreWithEFWebApi.Models
{
    public class MyProductBusinessLayer
    {

        MyProDAL dal;
        public MyProductBusinessLayer()
        {
            dal=new MyProDAL();
        }

        public List<MyProduct> ProductsList()
        {
           return  dal.MyProducts.ToList();
        }
        public MyProduct SaveMyProduct(MyProduct p)
        {
            dal.MyProducts.Add(p);
            dal.SaveChanges();
            return p;
        }
        public bool DeleteMyProduct(MyProduct p)
        {
            dal.MyProducts.Remove(p);
            dal.SaveChanges();
            return true;
        }

        public MyProduct Update(int id ,int newprice)
        {
            MyProduct p = ProductsList().Find(x => x.Id == id);
            p.Price = newprice;
            dal.SaveChanges();
            MyProduct p1= ProductsList().Find(y => y.Id == id);
            return p1;
        }

        
    }
}