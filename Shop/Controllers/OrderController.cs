using Microsoft.AspNetCore.Mvc;
using System;
using System.Web.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Controllers
{
    public class OrderController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopItems = shopCart.getShopItems();

            if (shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "� ��� ������ ���� ������!");
            }

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "����� ������� ���������";
            return View();
        }

    }
}