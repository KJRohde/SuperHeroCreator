using System;
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
            List<SuperHero> model = new List<SuperHero>();
            foreach (var x in context.Heroes)
            {
                model.Add(x);
            }
            return View(model);
        }

        // GET: Heroes/Details/5
        public ActionResult Details(int id)
        {
            SuperHero heroToRead = context.Heroes.FirstOrDefault(h => h.Id == id);
            return View(heroToRead);
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
                return View("Index");
            }
        }

        // GET: Heroes/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero heroToEdit = context.Heroes.FirstOrDefault(h => h.Id == id);
            return View(context);
        }

        // POST: Heroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperHero hero)
        {
            try
            {
                // TODO: Add update logic here
                SuperHero heroToEdit = context.Heroes.FirstOrDefault(h => h.Id == id);
                heroToEdit.Name = hero.Name;
                heroToEdit.AlterEgo = hero.AlterEgo;
                heroToEdit.PrimarySuperPower = hero.PrimarySuperPower;
                heroToEdit.AlternatePower = hero.AlternatePower;
                heroToEdit.CatchPhrase = hero.CatchPhrase;
                context.SaveChanges();
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
            SuperHero heroToDelete = context.Heroes.FirstOrDefault(h => h.Id == id);
            return View(heroToDelete);
        }

        // POST: Heroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SuperHero hero)
        {
            try
            {
                SuperHero heroToDelete = context.Heroes.FirstOrDefault(h => h.Id == id);
                context.Heroes.Remove(heroToDelete);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
