using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.ValueObjects;

namespace Application.Controllers
{
    public class CartController : Controller
    {
        private GoodsModel _goodsModel;
        public CartController(GoodsModel model)
        {
            _goodsModel = model;
        }

        public ActionResult Cart()
        {
            var cart = ((Cart)(Session["Cart"] ?? new Cart()));
            ViewData.Model = cart.GoodsInCart;
            return View();
        }

        public RedirectToRouteResult AddToCart(string controllerName, string actionName, int goodsId)
        {
            var goods = _goodsModel.Goods
                .FirstOrDefault(g => g.Id == goodsId);

            if (goods != null)
            {
                if (Session["Cart"] == null) Session["Cart"] = new Cart();
                var cart = (Cart)Session["Cart"];
                var goodsInCartIndex = cart.GoodsInCart.FindIndex(g => g.Goods.Equals(goods));

                if (goodsInCartIndex != -1) 
                {
                    var newGoodsInCart = cart.GoodsInCart[goodsInCartIndex];
                    newGoodsInCart.Quantity++;
                    if (newGoodsInCart.Quantity <= goods.Quantity) cart.GoodsInCart[goodsInCartIndex] = newGoodsInCart;
                }

                else
                    cart.GoodsInCart.Add(new OrderItemDetails() { Quantity = 1, Goods = goods }) ;
            }
            return RedirectToAction(actionName, controllerName);
        }

        public RedirectToRouteResult RemoveOneFromCart(int goodsId, string controllerName, string actionName)  
        {
            var goods = _goodsModel.Goods
                .FirstOrDefault(g => g.Id == goodsId);

            if (goods != null)
            {
                if (Session["Cart"] == null) return RedirectToAction(actionName, controllerName);
                var cart = (Cart)Session["Cart"];
                var goodsInCartIndex = cart.GoodsInCart.FindIndex(g => g.Goods.Equals(goods));
                if (goodsInCartIndex != -1)
                {
                    var newGoodsInCart = cart.GoodsInCart[goodsInCartIndex];
                    newGoodsInCart.Quantity--;
                    if (newGoodsInCart.Quantity == 0) cart.GoodsInCart.RemoveAt(goodsInCartIndex);
                    else cart.GoodsInCart[goodsInCartIndex] = newGoodsInCart;
                }
            }
            return RedirectToAction(actionName, controllerName);
        }

        public ActionResult RemoveAllFromCart(int goodsId)
        {
            var cart = (Cart)Session["Cart"];
            cart.GoodsInCart.Remove(cart.GoodsInCart.Find(g => g.Goods.Id == goodsId));
            return View("Cart", ((Cart)Session["Cart"]).GoodsInCart);
        }

        public ActionResult ProceedOrder()
        {
            return RedirectToAction("CreateOrder", "Order");
        }
    }
}