﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBog.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        // GET: Admin/Post
        public ActionResult Index()
        {
            return Content("Admin Posts!");
        }
    }
}