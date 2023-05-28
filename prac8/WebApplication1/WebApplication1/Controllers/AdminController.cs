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
    [Authorize]
    public class AdminController : Controller
    {
        private GoodsModel _goodsModel { get; set; }
        private OrdersAndGoodsModel _ordersAndGoodsModel { get; set; }
        private OrdersModel _ordersModel { get; set; }
        private CustomerModel _customersModel { get; set; }

        public AdminController(GoodsModel goodsModel, OrdersAndGoodsModel ordersAndGoodsModel,
                               OrdersModel ordersModel, CustomerModel customersModel)
        {
            _goodsModel = goodsModel;
            _ordersModel = ordersModel;
            _customersModel = customersModel;   
            _ordersAndGoodsModel = ordersAndGoodsModel;
        }
        [HttpGet]
        public ActionResult Admin()
        {
            return View("Admin", _goodsModel.Goods);
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            if (!ModelState.IsValid) return View();

            var model = _goodsModel.Goods.FirstOrDefault(g => g.Id == id);
            if (model == null) return View("Admin");
            return View("Edit", model);
        }
        [HttpPost]
        public ActionResult Edit(Goods goods)
        {
            _goodsModel.Goods.AddOrUpdate(goods);
            return Redirect(Url.Action("Admin", "Admin"));
        }

        [HttpGet]
        public ViewResult Add()
        {
            return View("Add", new Goods());
        }

        [HttpPost]
        public ActionResult Add(Goods goods)
        {
            if (!ModelState.IsValid) return View();

            _goodsModel.Goods.AddOrUpdate(goods);
            _goodsModel.SaveChanges();
            return Redirect(Url.Action("Admin", "Admin"));
        }


        public ViewResult Delete(int id)
        {
            var goods = _goodsModel.Goods.FirstOrDefault(g => g.Id == id);
            if (goods != null)
            {
                _goodsModel.Goods.Remove(goods);
                _goodsModel.SaveChanges();
            }
            return View("Admin", _goodsModel.Goods);
        }

        public ViewResult Orders()
        {
            var orderList = new List<OrderData>();
            foreach(var order in _ordersModel.Orders)
            {
                var orderData = new OrderData();
                orderData.Order = order;
                orderData.OrdersAndGoods = _ordersAndGoodsModel.OrdersAndGoods.Where((item) => item.OrderId == order.Id).ToList();
                orderData.Customer = _customersModel.Customers.FirstOrDefault((item) => item.Id == order.CustomerId);

                orderList.Add(orderData);
            }
            return View("Orders", orderList);
        }

        public ViewResult OrderDetails(int orderId)
        {
            var orderItems = new OrderItems();
            orderItems.Details = new List<OrderItemDetails>();
            orderItems.Id = orderId;

            var orderData = _ordersAndGoodsModel.OrdersAndGoods.Where(
                item => item.OrderId == orderId);
            foreach (var item in orderData)
            {
                var itemDetails = new OrderItemDetails();
                itemDetails.Goods = _goodsModel.Goods.Find(item.GoodsId);
                itemDetails.Quantity = item.Quantity;
                orderItems.Details.Add(itemDetails);
            }

            return View("Order", orderItems);
        }
    }
}