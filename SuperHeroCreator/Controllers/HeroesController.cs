﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SuperHeroCreator.Models;

namespace SuperHeroCreator.Controllers
{
    public class HeroesController : Controller
    {
        ApplicationDbContext context;
        public HeroesController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Heroes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Heroes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Heroes/Create
        public ActionResult Create()
        {
            SuperHero hero = new SuperHero();
            return View(hero);
        }

        // POST: Heroes/Create
        [HttpPost]
        public ActionResult Create(SuperHero hero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Heroes.Add(hero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Heroes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Heroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Heroes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Heroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
