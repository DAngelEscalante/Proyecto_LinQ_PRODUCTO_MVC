using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaProducto.Models;


namespace PracticaProducto.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productos1 = new List<Productos>
            {
                 new Productos {ID = 1, Descripcion = "Boligrafo", Precio = 8.25},
                 new Productos {ID = 2, Descripcion = "Cuaderno Grande", Precio = 21.5},
                 new Productos {ID = 3, Descripcion = "Cuaderno pequeño", Precio = 10},
                 new Productos {ID = 4, Descripcion = "Folios 40 uds", Precio = 550.55},
                 new Productos {ID = 5, Descripcion = "Grapadoras", Precio = 85.25},
                 new Productos {ID = 6, Descripcion = "Tijeras", Precio = 62},
                 new Productos {ID = 7, Descripcion = "Cinta Adhesiva", Precio = 45.10},
                 new Productos {ID = 8, Descripcion = "Rotulador", Precio = 20.75},
                 new Productos {ID = 9, Descripcion = "Mochila Escolar", Precio = 800.90},
                 new Productos {ID = 10, Descripcion = "Pegamento Barra", Precio = 30.15},
                 new Productos {ID = 11, Descripcion = "Lapicero", Precio = 15.55},
                 new Productos {ID = 12, Descripcion = "Grapas", Precio = 40.90}

                 


            };
            //Seleccionar los Producots con la letra "I"
           /* var ReProducto3 = from Productos in productos1
                              where Productos.Descripcion.Contains("I")
                              select Productos;

            return View(ReProducto3);


            var ReProducto2 = from Productos in productos1
                              where Productos.Descripcion.Contains("O")
                              select Productos;

            return View(ReProducto2);


            var ReProducto1 = from Productos in productos1
                             where Productos.Precio > 20
                             select Productos;

            return View(ReProducto1);*/
            // Seleccionar los Productos menores que 70
            var ReProducto = from Productos in productos1
                             where Productos.Precio < 70
                             select Productos;
                             
            return View(ReProducto);
        }
    }
}