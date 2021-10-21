using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona: Direccion
    {
        String clave, nombres, paterno, materno;
        String telefono;
        Char sexo;
        int edad;
        String fechaNacimiento, correo, nCasa, calle;

        public string Clave { get => clave; set => clave = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Paterno { get => paterno; set => paterno = value; }
        public string Materno { get => materno; set => materno = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Correo { get => correo; set => correo = value; }
        public string NCasa { get => nCasa; set => nCasa = value; }
        public string Calle { get => calle; set => calle = value; }
    }
    public class Empleado: Persona
    {
        int idEmpleado;
        string puesto;
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Puesto { get => puesto; set => puesto = value; }
    }
    public class Cliente:Persona
    {
        int idCliente;
        Double Credito;
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public double Credito1 { get => Credito; set => Credito = value; }
    }
    public class Usuario: Nivel
    {
        String nombre, contraseña, nombres, puesto, correo, id;
        int idEmpleado;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Id { get => id; set => id = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
    }   
    
    public class Nivel
    {
        int idNivel;
        String nivelU;
        String permisos;
        public int IdNivel { get => idNivel; set => idNivel = value; }       
        public string Permisos { get => permisos; set => permisos = value; }
        public string NivelU { get => nivelU; set => nivelU = value; }
    }
}
