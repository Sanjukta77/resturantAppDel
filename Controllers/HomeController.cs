using resturantAppDel.Models;
using resturantAppDel.Repository;
using resturantAppDel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace resturantAppDel.Controllers
{
    public class HomeController : Controller
    {

        ResturantAppEntities db = new ResturantAppEntities();

        CustomerRepository customerRepository = new CustomerRepository();
        ItemRepository itemRepository = new ItemRepository();
        PaymentTypeRepository paymentTypeRepository = new PaymentTypeRepository();


        [HttpGet]
        public ActionResult Index()
        {

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (customerRepository.getAllCustomer(), itemRepository.getAllItems(), paymentTypeRepository.getAllPayment());
            return View(objMultipleModels);
        }

        [HttpGet]
        public JsonResult getItemUnitPrice(int itemId)
        {
            var UnitPrice = db.Items.Single(x => x.ItemId == itemId).ItemPrice;

            return Json(UnitPrice, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public JsonResult Index(OrderViewModel ObjOrderViewModel)
        {
            OrderRepository orderRepository = new OrderRepository();

            bool value = orderRepository.AddOrder(ObjOrderViewModel);
            if (value == true)
            {
                return Json("value added", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("error", JsonRequestBehavior.AllowGet);
            }
           

        }

        public ActionResult About()
        {
            return View();
        }
    }
}