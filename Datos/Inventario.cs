using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;

namespace Datos
{
    public class ProveedorDatos : Transacciones
    {
        public override void Agregar(object c)
        {
            throw new NotImplementedException();
        }
                
        public override object Consultar(string c)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(string C)
        {
            throw new NotImplementedException();
        }
                
        public override List<object> LeerTodo()
        {
            throw new NotImplementedException();
        }

        public override void Moficicar(object c)
        {
            throw new NotImplementedException();
        }
    }
    public class ProductoDatos : Transacciones
    {
        public override void Agregar(object c)
        {
            throw new NotImplementedException();
        }
              
        public override object Consultar(string c)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(string C)
        {
            throw new NotImplementedException();
        }

        public override List<object> LeerTodo()
        {
            throw new NotImplementedException();
        }

        public override void Moficicar(object c)
        {
            throw new NotImplementedException();
        }
    }
    public class PedidoDatos : Transacciones
    {
        public override void Agregar(object c)
        {
            throw new NotImplementedException();
        }
               
        public override object Consultar(string c)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(string C)
        {
            throw new NotImplementedException();
        }
               
        public override List<object> LeerTodo()
        {
            throw new NotImplementedException();
        }

        public override void Moficicar(object c)
        {
            throw new NotImplementedException();
        }
    }
}
