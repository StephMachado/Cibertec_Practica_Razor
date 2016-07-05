using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.ActionFilters;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;
using WebDeveloper.Model.DTO;

namespace WebDeveloper.Controllers
{
    [LogActionFilter]
    [RoutePrefix("Razor")]
    public class RazorController : Controller
    {
        // GET: Razor
        [Route]
        public ActionResult Index()
        {
            var persons = new List<PersonModelView>
            {
                new PersonModelView {BusinessEntityID= 1, FirstName = "Stephany", MiddleName="Alexandra",
                                     LastName = "Machado Caballero", ModifiedDate= DateTime.Now, ImagePath= "/Images/FotoMujer.jpg"},
                new PersonModelView {BusinessEntityID= 2, FirstName = "Sophia", MiddleName="Berenisse",
                                    LastName = "Machado Caballero", ModifiedDate= DateTime.Now, ImagePath= "/Images/FotoMujer.jpg"},
                new PersonModelView {BusinessEntityID= 3, FirstName = "Joy", MiddleName="Quinterio",
                                    LastName = "Hurtado Caballero", ModifiedDate= DateTime.Now, ImagePath= "/Images/FotoVaron.jpg"},
                new PersonModelView {BusinessEntityID= 4, FirstName = "Noelia", MiddleName="Jimena",
                                    LastName = "Illescas Caballero", ModifiedDate= DateTime.Now, ImagePath= "/Images/FotoNoExiste.jpg"},
                new PersonModelView {BusinessEntityID= 5, FirstName = "Aracelly", MiddleName="Yanet",
                                    LastName = "Machado Caballero", ModifiedDate= DateTime.Now, ImagePath= "/Images/FotoNoExiste.jpg"},
                new PersonModelView {BusinessEntityID= 6, FirstName = "Aurelia", MiddleName="Magaly",
                                    LastName = "Santos Camacho", ModifiedDate= DateTime.Now, ImagePath= "/Images/FotoMujer.jpg"},
                new PersonModelView {BusinessEntityID= 7, FirstName = "Violea", MiddleName="Gladys",
                                    LastName = "Jimenez Sanchez", ModifiedDate= DateTime.Now, ImagePath= "/Images/FotoNoExiste.jpg"},
                new PersonModelView {BusinessEntityID= 8, FirstName = "Pamela", MiddleName="Evelyn",
                                    LastName = "De La Cruz Loja", ModifiedDate= DateTime.Now, ImagePath= "/Images/FotoMujer.jpg"},
                new PersonModelView {BusinessEntityID= 9, FirstName = "Roxana", MiddleName="Angie",
                                    LastName = "Loja Marchan", ModifiedDate= DateTime.Now, ImagePath= "/Images/FotoNoExiste.jpg"},
                new PersonModelView {BusinessEntityID= 10, FirstName = "Luis", MiddleName="Alberto",
                                    LastName = "Rodriguez Santos", ModifiedDate= DateTime.Now, ImagePath= "/Images/FotoNoExiste.jpg"},
                new PersonModelView {BusinessEntityID= 11, FirstName = "Aurelio", MiddleName="Felipe",
                                    LastName = "Vargas Sanchez", ModifiedDate= DateTime.Now, ImagePath= "/Images/FotoNoExiste.jpg"}
            };

            return View(persons);
        }
    }
}