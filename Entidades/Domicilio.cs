using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Region
    {
        int idRegion;
        String cuidad;
        String estado;
        public int IdRegion { get => idRegion; set => idRegion = value; }
        public string Cuidad { get => cuidad; set => cuidad = value; }
        public string Estado { get => estado; set => estado = value; }
    }
    public class Direccion: Region
    {
        int idDireccion;
        String colonia;
        int cp;
        public int IdDireccion { get => idDireccion; set => idDireccion = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public int Cp { get => cp; set => cp = value; }

        
    }
}
