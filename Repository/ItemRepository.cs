using resturantAppDel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace resturantAppDel.Repository
{
    public class ItemRepository
    {

        ResturantAppEntities db = new ResturantAppEntities();


        public IEnumerable<SelectListItem> getAllItems()
        {
            IEnumerable<SelectListItem> selectListItems = new List<SelectListItem>();
            selectListItems = (from ObjItems in db.Items

                               select new SelectListItem()
                               {
                                   Value = ObjItems.ItemId.ToString(),
                                   Text = ObjItems.ItemName

                               }).ToList();

            return selectListItems;
        }
    }
}