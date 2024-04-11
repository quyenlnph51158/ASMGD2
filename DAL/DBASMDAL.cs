using DTO.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DAL
{
    public class DBASMDAL
    {
        DbasmCContext DbasmCContext = new DbasmCContext();
        public List<Customer> GetCustomersAll()
        {
            var cus = DbasmCContext.Customers.ToList();
            return cus;
        }
        public List<Order> GetOrdersAll()
        {
            var order = DbasmCContext.Orders.ToList();
            return order;
        }
        public List<OrderItem> GetOrderItemsAll()
        {
            var orderitem = DbasmCContext.OrderItems.ToList();
            return orderitem;
        }
        public List<Product> GetProductsAll()
        {
            var product = DbasmCContext.Products.ToList();
            return product;
        }
        public List<Supplier> GetSuppliersAll()
        {
            var supply = DbasmCContext.Suppliers.ToList();
            return supply;
            
        }
        // Product
        public void addProduct(Product pro)
        {

            
                DbasmCContext.Products.Add(pro);
                DbasmCContext.SaveChanges();
                
        }
        public void removeProduct(Product pro)
        {

            
            DbasmCContext.Products.Remove(pro);
            DbasmCContext.SaveChanges();
        }
        public void removeProduct1( OrderItem odr)
        {
            DbasmCContext.OrderItems.Remove(odr);
            DbasmCContext.SaveChanges();
            
        }

        public void UpdateValues()
        {
            DbasmCContext.SaveChanges();

        }
        // Customer
        
        public void ADDCustomer(Customer csm)
        {
            DbasmCContext.Customers.Add(csm);
            DbasmCContext.SaveChanges();

        }
        public void removeCustomer(Customer csm)
        {
            DbasmCContext.Customers.Remove(csm);
            DbasmCContext.SaveChanges();
        }
        public void updateCustomer()
        {
            DbasmCContext.SaveChanges(); 
        }
        // Order
        public void ADDOrder(Order order)
        {
            DbasmCContext.Orders.Add(order);
            DbasmCContext.SaveChanges();
        }
        public void RemoveOrder(Order odr)
        {
            DbasmCContext.Orders.Remove(odr);
            DbasmCContext.SaveChanges();
        }
        public void UpdateOrder()
        {
            DbasmCContext.SaveChanges();
        }

        public void addOrderItem(OrderItem item)
        {
            DbasmCContext.OrderItems.Add(item);
            DbasmCContext.SaveChanges();
        }
        


    }
}
