﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ViewdataVsViewBag.Controllers
{
    public class HomeController : Controller
    {
        GetPostEntities OE = new GetPostEntities();
        public ActionResult Index()
        {
            var AllRecords = OE.tbl_MyTable.ToList();
            ViewBag.LR = AllRecords;

            return View();
        }
        public ActionResult Read(int ID)
        {
            //var Name = OE.tbl_MyTable.Where(p => p.ID == ID).FirstOrDefault().Name;
            //var Age = OE.tbl_MyTable.Where(p => p.ID == ID).FirstOrDefault().Age;
            var obj = OE.tbl_MyTable.Where(p => p.ID == ID).FirstOrDefault();


            //ViewData["N"] = Name;
            //ViewData["A"] = Age; Instead of ViewData we can use ViewBag as its syntax is close to C#

            //ViewBag.N=Name;
            //ViewBag.A = Age;
            //ViewData["O"] = obj;

            ViewBag.O = obj;

             

            return View("Index");//getting back to index view after being redirected from index view to read
        }

       
    }
}