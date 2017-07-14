using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class clsCliente
    {
        public bool insertarNacional(String identificacion, String nombre, String apellido1, String apellido2, int genero, int tipoCliente)
        {       
            return new CapaDatos.ClsCliente().insertarNacional(identificacion, nombre, apellido1, apellido2, genero, tipoCliente);
        }

        public bool insertarExtranjero(String identificacion, String nombre, String apellido1, String apellido2, int genero, int tipoCliente)
        {
            return new CapaDatos.ClsCliente().insertarExtranjero(identificacion, nombre, apellido1, apellido2, genero, tipoCliente);
        }
    }
}

