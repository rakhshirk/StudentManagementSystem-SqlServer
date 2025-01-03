﻿using System;
using Microsoft.AspNetCore.Mvc;
using WebAppDatabase.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebAppDatabase.Controllers
{
    public class TeacherController : Controller
    {
        private readonly MyContext _context;

        public TeacherController()
        {
            _context = new MyContext();
        }
        public IActionResult Index()
        {
            var teachers = _context.Teachers.ToArray();
            return View(teachers);
        }
        
        public IActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeacher(Teacher teach)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Teachers.Add(teach);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                  
                    ViewBag.ErrorMessage = "An error occurred: " + ex.Message;
                    return View(teach);
                }
            }
            return View(teach);
        }
   
    }

}
