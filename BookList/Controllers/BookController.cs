﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookList.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _db.Book.ToList()});
        }
    }
}
