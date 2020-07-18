using AutoMapper;
using BL.Interfaces;
using DependencyInjection_MVC5.Models;
using DL;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DependencyInjection_MVC5.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly IOrderItemRepository _orderItemRepository;
        public OrderController(IOrderRepository orderRepository, IMapper mapper,
            IOrderItemRepository orderItemRepository)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _orderItemRepository = orderItemRepository;
        }
        // GET: Order
        public ActionResult Index(int customerId)
        {
            var orders = _mapper.Map<List<order>, List<Order>>(_orderRepository.GetOrdersByCustomerId(customerId));
            return View(orders);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            var orderDetails = _mapper.Map<order, Order>(_orderRepository.GetOrdersByOrderId(id));
            var orderItems = _mapper.Map<List<order_items>, List<OrderItems>>(_orderItemRepository.GetOrderItemsByOrderId(id));
            var orderViewModel = new OrderViewModel
            {
                OrderDetails = orderDetails,
                Items = orderItems,
                TotalPrice = orderItems.Sum(x => x.quantity * x.list_price)
            };
            return View(orderViewModel);
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        //[Route("OrderDetails")]
        //[HttpGet]
        //public ActionResult GetOrderDetails()
        //{
        //    return View();
        //}

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
