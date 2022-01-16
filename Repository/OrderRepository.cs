using resturantAppDel.Models;
using resturantAppDel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resturantAppDel.Repository
{
    
    public class OrderRepository
    {
        ResturantAppEntities db = new ResturantAppEntities();

        public bool AddOrder(OrderViewModel ObjOrderViewModel)
        {
            Random r = new Random();
            Order order = new Order();
            order.CustomerId = ObjOrderViewModel.CustomerId;
            order.OrderNumber = (r.Next()).ToString();
            order.OrderDate = DateTime.Now;
            order.PaymentITyped = ObjOrderViewModel.PaymentTypeId;
            order.FinalTotal = ObjOrderViewModel.FinalTotal;
            db.Orders.Add(order);
            db.SaveChanges();
            int orderId = order.OrderId;

            foreach (var list in ObjOrderViewModel.ListOfOrderDetailViewModel)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.OrderId = orderId;
                orderDetail.Quantity = list.Quantity;
                orderDetail.Total = list.Total;
                orderDetail.UnitPrice = list.UnitPrice;
                orderDetail.Discount = list.Discount;
                orderDetail.ItemId = list.ItemId;
                db.OrderDetails.Add(orderDetail);
                db.SaveChanges();


                Transaction transaction = new Transaction();
                transaction.TypeId = 2;
                transaction.TransactionDate = DateTime.Now;
                transaction.Quantity = list.Quantity;
                transaction.ItemId = list.ItemId;
                db.Transactions.Add(transaction);
                db.SaveChanges();

            }

            return true;
        }


    }
}