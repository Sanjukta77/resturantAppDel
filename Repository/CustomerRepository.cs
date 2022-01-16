using resturantAppDel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace resturantAppDel.Repository
{
    public class CustomerRepository
    {

        ResturantAppEntities db = new ResturantAppEntities();


        public IEnumerable<SelectListItem> getAllCustomer()
        {
            IEnumerable<SelectListItem> selectListItems = new List<SelectListItem>();
            selectListItems = (from ObjCustomers in db.Customers

                               select new SelectListItem()
                               {
                                   Value = ObjCustomers.CustomerId.ToString(),
                                   Text = ObjCustomers.CustomerName

                               }).ToList();

            return selectListItems;
        }

    }
}