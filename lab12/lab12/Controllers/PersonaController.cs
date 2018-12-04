using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab12.Models;

namespace lab12.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Mostrar(int id) {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "av. evergreen 123",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "JUAN@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "Maria",
                Apellido = "Salas",
                Direccion = "av. progreso 123",
                FechaNac = Convert.ToDateTime("1997-11-17"),
                Email = "mari@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "carlos",
                Apellido = "martinez",
                Direccion = "av. manzanos 123",
                FechaNac = Convert.ToDateTime("1997-11-14"),
                Email = "carlos@mail.com"
            });
            Persona persona = (from p in personas
                               where p.PersonaID == id
                               select p).FirstOrDefault();
            return View(persona);
        }
        public ActionResult Listar() {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "av. evergreen 123",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "JUAN@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "Maria",
                Apellido = "Salas",
                Direccion = "av. progreso 123",
                FechaNac = Convert.ToDateTime("1997-11-17"),
                Email = "mari@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "carlos",
                Apellido = "martinez",
                Direccion = "av. manzanos 123",
                FechaNac = Convert.ToDateTime("1997-11-14"),
                Email = "carlos@mail.com"
            });
            return View(personas);
        }
    
    }
}