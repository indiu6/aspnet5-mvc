﻿using Microsoft.AspNetCore.Mvc;
using SimpleMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMvcApp.Controllers
{
    public class ItemController : Controller
    {
        private readonly AppDbContext _db;

        public ItemController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }
    }
}
