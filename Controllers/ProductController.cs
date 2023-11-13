﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSDL.Models;

namespace CSDL.Controllers
{
    public class ProductController : Controller
    {
        DBQLBanHangEntities database = new DBQLBanHangEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View(database.tblStaffs.ToList());
        }
    }
}