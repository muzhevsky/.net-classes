using Application.Models;
using Application.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.Controllers
{
    public class OrderController : Controller
    {
        private CustomerModel _customerModel;
        private OrdersModel _ordersModel;
        private OrdersAndGoodsModel _ordersAndGoodsModel;

        public OrderController(CustomerModel customerModel, OrdersModel ordersModel, OrdersAndGoodsModel ordersAndGoodsModel)
        {
            _customerModel = customerModel;
            _ordersModel = ordersModel;
            _ordersAndGoodsModel = ordersAndGoodsModel;
        }

        [HttpGet]
        public ViewResult CreateOrder()
        {
            if ((Cart)Session["Cart"] == null) return View("Cart");
            ViewBag.GoodsInCart = ((Cart)Session["Cart"]).GoodsInCart;
            return View("CreateOrder");
        }

        [HttpPost]
        public ActionResult CreateOrder(Customer customer)
        {
            if (ModelState.IsValid)
            {
                var customerRecord = _customerModel.Customers.FirstOrDefault(c => c.Email == customer.Email);
                if (customerRecord != null)
                {
                    customer.Id = customerRecord.Id;
                    _customerModel.Customers.AddOrUpdate(customer);
                }
                else
                    _customerModel.Customers.Add(customer);
                _customerModel.SaveChanges();

                var order = new Order(customer.Id);
                _ordersModel.Orders.Add(order);
                _ordersModel.SaveChanges();

                var goodsInCart = ((Cart)Session["Cart"]).GoodsInCart;
                var ordersAndGoods = goodsInCart.Select((item) => new OrdersAndGoods(order.Id, item.Goods.Id, item.Quantity)).ToList();
                _ordersAndGoodsModel.OrdersAndGoods.AddRange(ordersAndGoods);
                _ordersAndGoodsModel.SaveChanges();
                var test = _ordersAndGoodsModel.OrdersAndGoods.FirstOrDefault((item) => item.OrderId == order.Id);

                return RedirectToAction("Goods", "Goods");
            }

            return View();
        }
    }
}