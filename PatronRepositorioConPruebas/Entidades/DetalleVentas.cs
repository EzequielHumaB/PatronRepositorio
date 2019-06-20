using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorioConPruebas.Entidades
{
   public class DetalleVentas
    {
        public int DetalleVentasId { get; set; }
        public int Ventas_VentasId { get; set; }
        public int Productos_ProductoId { get; set; }
        public double Unidades { get; set; }
        public double CostoUnidad { get; set; }
        public double DescuentoUnidad { get; set; }
        public double Total { get; set; }

        public DetalleVentas()
        {
            DetalleVentasId = 0;
            Ventas_VentasId = 0;
            Productos_ProductoId = 0;
            Unidades = 0.0d;
            CostoUnidad = 0.0d;
            DescuentoUnidad = 0.0d;
            Total = 0.0d;
        }

    }
}
