using SoporteTecnico.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoporteTecnico.Web.Controllers
{
    public class ServiciosController : Controller
    {
        // GET: Servicios
        public ActionResult Index()
        {
            var servicio1= new ProductoModel();
            servicio1.Id = 1;
            servicio1.Descripcion = "Instalacion de Software";
            servicio1.Precio = 500.00
            var servicio2 = new ProductoModel();
            servicio2.Id = 2;
            servicio2.Descripcion = "Mantenimiento Preventivo";

            var servicio3 = new ProductoModel();
            servicio3.Id = 3;
            servicio3.Descripcion = "Taller de Reparación";


            var listadeServicios = new List<ProductoModel>();
            listadeServicios.Add(servicio1);
            listadeServicios.Add(servicio2);
            listadeServicios.Add(servicio3);

            return View(listadeServicios);

        }
    }
}