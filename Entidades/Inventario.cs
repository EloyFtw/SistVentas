using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor: Direccion
    {
        int idProveedor;
        String distribuidora, telefono, correo, calle;
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string Distribuidora { get => distribuidora; set => distribuidora = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Calle { get => calle; set => calle = value; }
    }
    public class Producto: Proveedor
    {
        String codigo, descripcion;
        double compra, venta;
        int stock;
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Compra { get => compra; set => compra = value; }
        public double Venta { get => venta; set => venta = value; }
        public int Stock { get => stock; set => stock = value; }
    }
    public class Pedido: Producto
    {
        String idPedido, descripcionPedido, estatus, fecha;
        int cantidad;

        public string IdPedido { get => idPedido; set => idPedido = value; }
        public string Estatus { get => estatus; set => estatus = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string DescripcionPedido { get => descripcionPedido; set => descripcionPedido = value; }
    }
}
