using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClsCliente
    {

        ClsConexion conect = new ClsConexion();

        public bool insertarNacional(String identificacion,String nombre, String apellido1, String apellido2,int genero,int tipoCliente)
        {
            bool creandoPersona, creandoNacional, creandoCliente;

            creandoPersona = conect.ejecutarInsert("insert into persona (idPersona,TipoPersona_idTipoPersona) values ('"+identificacion+"',1)");
            creandoCliente = conect.ejecutarInsert("insert into cliente (Persona_idPersona,TipoCliente_idTipoCliente) values ('"+identificacion+"',"+tipoCliente+");");
            creandoNacional = conect.ejecutarInsert("insert into personanacional(Persona_idPersona,Nombre,Apellido1,Apellido2,Genero_idGenero) values ('"+identificacion+"','"+nombre+"','"+apellido1+"','"+apellido2+"',"+genero+")");
            if(creandoPersona && creandoNacional && creandoCliente)
            {
                return true;
            }
                return false;
        }


        public bool insertarExtranjero(String identificacion, String nombre, String apellido1, String apellido2, int genero, int tipoCliente)
        {
            bool creandoPersona, creandoExtranjero, creandoCliente;

            creandoPersona = conect.ejecutarInsert("insert into persona (idPersona,TipoPersona_idTipoPersona) values ('" + identificacion + "',2)");
            creandoCliente = conect.ejecutarInsert("insert into cliente (Persona_idPersona,TipoCliente_idTipoCliente) values ('" + identificacion + "'," + tipoCliente + ");");
            creandoExtranjero = conect.ejecutarInsert("insert into personaextranjera(Persona_idPersona,Nombre,Apellido1,Apellido2,Genero_idGenero) values ('" + identificacion + "','" + nombre + "','" + apellido1 + "','" + apellido2 + "'," + genero + ")");
            if (creandoPersona && creandoExtranjero && creandoCliente)
            {
                return true;
            }
            return false;
        }

        public DataTable buscar(int identificacion)
        {
            DataTable dtClientes;
            dtClientes = conect.ejecutar("select Persona_idPersona from cliente where Persona_idPersona=('" + identificacion + "')");
            return dtClientes;
        }
    }
}
