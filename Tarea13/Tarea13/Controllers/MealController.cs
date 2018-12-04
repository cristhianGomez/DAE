using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea13.Models;

namespace Tarea13.Controllers
{
    public class MealController : Controller
    {
        // GET: Meal
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Mostrar(int id) {

            List<Meals> meals = new List<Meals>();
            meals.Add(new Meals
            {
                MeaID = 1,
                Name = "Lomo saltado",
                Description = "Delicioso plato de lomo",
                MealType = "Plato principal",
                Picture = "No",
                Cost = "25 soles"


            });
            meals.Add(new Meals
            {
                MeaID = 2,
                Name = "Arroz con leche",
                Description = "Delicioso postre",
                MealType = "Postre",
                Picture = "No",
                Cost = "5 soles"


            });
            meals.Add(new Meals
            {
                MeaID = 3,
                Name = "Caldo Blanco",
                Description = "Delicioso",
                MealType = "Plato entrada",
                Picture = "No",
                Cost = "10 soles"


            });
            Meals meal = (from p in meals
                               where p.MeaID == id
                               select p).FirstOrDefault();
            return View(meal);
        }
        public ActionResult Listar()
        {
            List<Meals> meals = new List<Meals>();
            meals.Add(new Meals
            {
                MeaID = 1,
                Name = "Lomo saltado",
                Description = "Delicioso plato de lomo",
                MealType = "Plato principal",
                Picture = "No",
                Cost = "25 soles"


            });
            meals.Add(new Meals
            {
                MeaID = 2,
                Name = "Arroz con leche",
                Description = "Delicioso postre",
                MealType = "Postre",
                Picture = "No",
                Cost = "5 soles"


            });
            meals.Add(new Meals
            {
                MeaID = 3,
                Name = "Caldo Blanco",
                Description = "Delicioso",
                MealType = "Plato entrada",
                Picture = "No",
                Cost = "10 soles"


            });
            return View(meals);
        }


    }
}