using resturantAppDel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace resturantAppDel.Repository
{
    
    public class PaymentTypeRepository
    {
        ResturantAppEntities db = new ResturantAppEntities();


        public IEnumerable<SelectListItem> getAllPayment()
        {
            IEnumerable<SelectListItem> selectListItems = new List<SelectListItem>();
            selectListItems = (from objPaymetList in db.PaymentTypes

                               select new SelectListItem()
                               {
                                   Value = objPaymetList.PaymentTypeId.ToString(),
                                   Text = objPaymetList.PaymentTypeName

                               }).ToList();

            return selectListItems;
        }
    }
}