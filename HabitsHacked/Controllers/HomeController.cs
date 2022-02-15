using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HabitsHacked.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HabitsHacked.Controllers
{
    public class HomeController : Controller
    {
        //controller to pass data to database 
        private TaskInfoContext _habitAdder { get; set; }

        public HomeController(TaskInfoContext variable)
        {
            _habitAdder = variable;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Quadrants");
        }

        public IActionResult Quadrants()
        {
            var alltasks = _habitAdder.TaskResponses
                .Include(x => x.Category)
                .ToList();

            return View(alltasks);
        }

        //Create Task controllers
        [HttpGet]
        public IActionResult addtask()
        {
            //may need to pass Categories to view for display dynamic list
            //ViewBag.Categories = _habitAdder.Categories.ToList();

            return View();
        }

        //[HttpPost]
        ////cr = what being passed from the form
        //public IActionResult addtask(ModelName cr)
        //{
        //    ViewBag.Categories = _habitAdder.Categories.ToList();

        //    //not sure if we need validation - can delete if we don't want to use, just keep the return statement
        //    if (ModelState.IsValid)
        //    {
        //        //get data from form
        //        _habitAdder.Add(cr);
        //        //save changes
        //        _habitAdder.SaveChanges();

        //        return RedirectToAction("Quadrant");
        //    }
        //    else //if data doesn't meet requirements
        //    {
        //        return View(cr);
        //    }
        //}


        //EDIT page controllers
        [HttpPost]
        public IActionResult Edit(TaskFormResponse cr)
        {
            if (ModelState.IsValid)
            {
                _habitAdder.Update(cr);
                _habitAdder.SaveChanges();

                //need to redirecttoaction, or pass in all Film Collection data again
                return RedirectToAction("Quadrant");
            }
            else
            {
                return View(cr);
            }

        }

        [HttpGet]
        public IActionResult Edit(int movieID)
        {
            ViewBag.Categories = _habitAdder.Categories.ToList();

            //ToString pull record using Find (then do itar by ID), or Single (expects criteria to find 1 entry)
            var task = _habitAdder.TaskResponses.Single(x => x.TaskID == movieID);

            //let me know if want to edit in new view, or if CreateTaskView
            return View("addtask", task);
        }

        //DELETE page controllers
        [HttpGet]
        public IActionResult Delete(int taskid)
        {
            var task = _habitAdder.TaskResponses.Single(x => x.TaskID == taskid);

            return View(task);
        }

        [HttpPost]
        //pass in model feilds for specific row > need to pass in Id as hidden feild on delete page
        public IActionResult Delete(TaskFormResponse tfr)
        {
            _habitAdder.TaskResponses.Remove(tfr);
            _habitAdder.SaveChanges();

            return RedirectToAction("Quadrants");
        }

    }
}
