using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteTecnico.BL
{
    public class ServiciosBL
    {

        public List<Servicio> ObtenerServicios()
        {
            var servicio1 = new Servicio();
            servicio1.Id = 1;
            servicio1.Descripcion = "Instalación de Software";
            servicio1.Precio = 500.00;

            var servicio2 = new Servicio();
            servicio2.Id = 2;
            servicio2.Descripcion = "Mantenimiento Preventivo";
            servicio2.Precio = 1000.00;

            var servicio3 = new Servicio();
            servicio3.Id = 3;
            servicio3.Descripcion = "Taller de Reparación";
            servicio3.Precio = 200.00;

            var listadeServicios = new List<Servicio>();
            listadeServicios.Add(servicio1);
            listadeServicios.Add(servicio2);
            listadeServicios.Add(servicio3);

            return listadeServicios;

        }
    }
}

