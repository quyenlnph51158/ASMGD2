using DAL;
using DTO.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DBASMBLL
    {
        
        DBASMDAL dBASMDAL=new DBASMDAL();
        
        //Khu vuc get
        
        private Supplier GetSupplyIdByCompanyName(string name)
        {
            foreach (var i in dBASMDAL.GetSuppliersAll())
            {
                if (i.CompanyName.Equals(name))
                {
                    return i;
                }
            }
            return null;
        }
        public Product GetProductByName(string name)
        {
            foreach(var i in dBASMDAL.GetProductsAll())
            {
                if (i.ProductName.Equals(name))
                {
                    return i;
                }
            }
            return null;
        }
        private Product GetProductByID(int id)
        {
            foreach (var i in dBASMDAL.GetProductsAll())
            {
                if (i.Id.Equals(id))
                {
                    return i;
                }

            }
            return null;
        }
        private Supplier GetSupplyfromId(int id)
        {
            foreach (var i in dBASMDAL.GetSuppliersAll())
            {
                if (i.Id.Equals(id))
                {
                    return i;
                }
            }
            return null;
        }
        private Customer getCustomerFromId(int id)
        {
            foreach(var i in dBASMDAL.GetCustomersAll())
            {
                if (i.Id.Equals(id))
                {
                    return i;
                }
            }
            return null;
        }

        public Customer GetCustomerByName(string name)
        {
            foreach (var i in dBASMDAL.GetCustomersAll().ToList())
            {
                if ((i.FirstName + " " + i.LastName).Equals(name))
                {
                    return i;
                }
            }
            return null;
        }

        public Order GetOrderById(int id)
        {
            foreach(var i in dBASMDAL.GetOrdersAll().ToList())
            {
                if (i.Id.Equals(id))
                {
                    return i;

                }
            }
            return null;
        }
        public OrderItem GetOrderItembyId(int id)
        {
            foreach(var i in dBASMDAL.GetOrderItemsAll().ToList())
            {
                if (i.Id.Equals(id))
                {
                    return i;
                }
            }
            return null;

        }
        public OrderItem GetOrderItembyIdProduct(int id)
        {
            foreach (var i in dBASMDAL.GetOrderItemsAll().ToList())
            {
                if (i.ProductId.Equals(id))
                {
                    return i;
                }
            }
            return null;

        }
        public List<Product> GetProductsALLBLL()
        {
            var i = dBASMDAL.GetProductsAll();
            return i;
        }
        public List<Supplier> GetSuppliersALLBLL()
        {
            var i =dBASMDAL.GetSuppliersAll();
            return i;
        }
        public List<Customer> GetCustomersALLBLL()
        {
            var i=dBASMDAL.GetCustomersAll();
            return i;
        }
        public List<Product> GetProductBySearchName( string l)
        {
            var i=dBASMDAL.GetProductsAll().ToList().Where(o=>o.ProductName.ToLower().Contains(l));
            return i.ToList();
        }
        public List<Order> GetOrdersALLBLL()
        {
            var i=dBASMDAL.GetOrdersAll();
            return i;
        }
        public List<OrderItem> GetOrderItemsALLBLL()
        {
            var i =dBASMDAL.GetOrderItemsAll();
            return i;
        }
        

        //Khu chuc nang product
       
        public void ADDProduct(string ProductName,string SupplierId, string UnitPrice, string Package, bool IsDiscontinued)
        {

            var productName = ProductName;
            var Price = Convert.ToDecimal(UnitPrice);
            var supplyId = Convert.ToInt32(GetSupplyIdByCompanyName(SupplierId).Id);
            var package = Package;
            var continuee = IsDiscontinued;
            
            Product product = new Product();
            product.ProductName = productName;
            product.SupplierId = supplyId;
            product.UnitPrice = Price;
            product.Package = package;
            product.IsDiscontinued = continuee;
            dBASMDAL.addProduct( product);
        }
        public void removeProduct(string pr)
        {
            var prId = Convert.ToInt32(pr);
            var ProductMuonXoa = GetProductByID(Convert.ToInt32(prId));
            //OrderItem item = new OrderItem();
            //item.Id = i;
            //item.ProductId = o;
            //item.OrderId = k;
            //item.UnitPrice = j;
            //item.Quantity = y;
            
           
          
            
            
            
            dBASMDAL.removeProduct( ProductMuonXoa);
        }
        
        public void UpdateProduct(string prIdd,string ProductName, string SupplierId, string UnitPrice, string Package, bool IsDiscontinued)
        {
            var prId = Convert.ToInt32(prIdd);
            var productName = ProductName;
            var Price = Convert.ToDecimal(UnitPrice);
            var supplyId = Convert.ToInt32(GetSupplyIdByCompanyName(SupplierId).Id);
            var package = Package;
            var continuee = IsDiscontinued;
            var UpdateProduct = GetProductByID(Convert.ToInt32(prId));
            UpdateProduct.ProductName = productName;
            UpdateProduct.SupplierId = supplyId;
            UpdateProduct.UnitPrice = Price;
            UpdateProduct.Package = package;
            UpdateProduct.IsDiscontinued = continuee;
            dBASMDAL.UpdateValues();
        }
        //khu chuc nang customer
        public void ADDCustomer(string fn,string ln,string city, string country,string phone)
        {
            var firstName = fn;
            var lastName = ln;
            var Cities = city;
            var Countries = country;
            var Phones = phone;
            Customer customer=new Customer();
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.City = Cities;
            customer.Country = Countries;
            customer.Phone = Phones;
            dBASMDAL.ADDCustomer(customer);
        }
        public void RemoveCTMS(string id) 
        {
            var Id = Convert.ToInt32(id);
            var cstm=getCustomerFromId(Id);
            dBASMDAL.removeCustomer(cstm);
        }
        public void UpdateCTMS(string i,string fn, string ln, string city, string country, string phone)
        {
            var id = Convert.ToInt32(i);
            var firstName = fn;
            var lastName = ln;
            var Cities = city;
            var Countries = country;
            var Phones = phone;
            Customer customer = getCustomerFromId(id);
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.City = Cities;
            customer.Country = Countries;
            customer.Phone = Phones;
            dBASMDAL.updateCustomer();
        }
        //Khu Order
        public void ADDOrder(DateTime orderdatee, string orderNumberr,string cs,string total)
        {
            var orderdate= orderdatee;
            var orderNumbe = orderNumberr;
            var csbe = Convert.ToInt32(GetCustomerByName(cs).Id);
            var totalbe = Convert.ToDecimal(total);
            Order order = new Order();
            order.OrderDate= orderdate;
            order.OrderNumber= orderNumbe;
            order.CustomerId=csbe;
            order.TotalAmount = totalbe;
            dBASMDAL.ADDOrder(order);


        }
        public void removeOrder(string i)
        {
            var id= Convert.ToInt32(i);
            var orderr=GetOrderById(id);
            dBASMDAL.RemoveOrder(orderr);

        }
        public void UpdateOrder(string id,DateTime orderdatee, string orderNumberr, string cs, string total)
        {
            var idd= Convert.ToInt32(id);
            var orDatebe = orderdatee;
            var orNumbe = orderNumberr;
            var ccbe = Convert.ToInt32(GetCustomerByName(cs).Id);
            var totalbe = Convert.ToDecimal(total);
            Order order = GetOrderById(idd);
            order.OrderDate= orderdatee;
            order.OrderNumber= orderNumberr;
            order.CustomerId = ccbe;
            order.TotalAmount= totalbe;
            dBASMDAL.UpdateOrder();
        }
        public void OrderDetail(string n)
        {
            var nn=Convert.ToInt32(n);
            var i = dBASMDAL.GetOrdersAll().ToList().Join(dBASMDAL.GetOrderItemsAll().ToList(),
                order=>order.Id,
                orderItem=>orderItem.OrderId,
                (order, orderItem) => new
                {
                    
                    order.CustomerId,
                    order.TotalAmount,
                    order.OrderDate,
                    order.OrderNumber,
                    orderItem.Quantity,
                    orderItem.UnitPrice,
                    orderItem.Id,
                    orderItem.OrderId,
                    orderItem.ProductId

                }).Where(o=>o.OrderId==nn);
            
           
        }
        //Khu ban hang
        public void addOrderItem(string i, string o, decimal k, string m) 
        {
            var or= Convert.ToInt32(i);
            var n = Convert.ToInt32(o);
            var p = k;
            var q = Convert.ToInt32(m);
            OrderItem item=new OrderItem();
            item.OrderId = or;
            item.ProductId = n;   
            item.UnitPrice = p;
            item.Quantity = q;
            dBASMDAL.addOrderItem(item);
        }
        
    }
}
