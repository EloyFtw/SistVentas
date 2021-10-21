using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class Transacciones
    {
       public abstract void Agregar(object c);
        public abstract void Moficicar(object c);
        public abstract void Eliminar(String c);
        public abstract object Consultar(String c);
        public abstract List<object> LeerTodo();
    }
}
