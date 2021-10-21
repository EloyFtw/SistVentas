using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta: Empleado
    {
        String folio, caja, fecha;
        double monto, cambio, total;
        public string Folio { get => folio; set => folio = value; }
        public string Caja { get => caja; set => caja = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public double Monto { get => monto; set => monto = value; }
        public double Cambio { get => cambio; set => cambio = value; }
        public double Total { get => total; set => total = value; }
    }
    public class CargoVenta:Producto
    {
        String folioV;
        double precio, total;
        int cantidad;
        public string FolioV { get => folioV; set => folioV = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Total { get => total; set => total = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
    public class Apartado: Cliente
    {
        String folio, fkProducto, descripcionProducto, fecha_Ini, fecha_Fin;
        double adeudo, abonado, precioU, total;
        int cantidad;
        public string Folio { get => folio; set => folio = value; }
        public string FkProducto { get => fkProducto; set => fkProducto = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        public string Fecha_Ini { get => fecha_Ini; set => fecha_Ini = value; }
        public string Fecha_Fin { get => fecha_Fin; set => fecha_Fin = value; }
        public double Adeudo { get => adeudo; set => adeudo = value; }
        public double Abonado { get => abonado; set => abonado = value; }
        public double PrecioU { get => precioU; set => precioU = value; }
        public double Total { get => total; set => total = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
