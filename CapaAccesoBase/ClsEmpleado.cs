﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClsEmpleado
    {
        ClsConexion conect = new ClsConexion();

        public bool insertarNacional(String identificacion, String nombre, String apellido1, String apellido2, int genero, String Usuario, String Contraseña, int TipoEmpleado, int provincia, int canton, int Distrito, String Descripcion,int activo, int telefono, int tipoTelefono, String mail, int tipoMail)
        {
            bool creandoPersona, creandoNacional,creandoUsuario,creandoEmpleado,creandoDireccion,creandoTel,creandoMail;

            creandoPersona = conect.ejecutarInsert("insert into persona (idPersona,TipoPersona_idTipoPersona) values ('" + identificacion + "',1)");
            creandoNacional = conect.ejecutarInsert("insert into personanacional(Persona_idPersona,Nombre,Apellido1,Apellido2,Genero_idGenero) values ('" + identificacion + "','" + nombre + "','" + apellido1 + "','" + apellido2 + "'," + genero + ")");
            creandoUsuario = conect.ejecutarInsert("insert into usuario(Persona_idPersona,NombreUsuario,Contraseña,TipoUsuario_idTipoUsuario,Activo) values ('" + identificacion+ "','" +Usuario+ "','" +Contraseña+ "'," +TipoEmpleado+ "," +activo+ ")");
            creandoEmpleado = conect.ejecutarInsert("insert into empleado (Usuario_NombreUsuario,Usuario_Persona_idPersona,TipoEmpleado_idTipoEmpleado) values ('" +Usuario+ "'," +identificacion+ "," +TipoEmpleado+ ")");
            creandoDireccion = conect.ejecutarInsert("insert into direccion(Persona_idPersona,Distrito_idDistrito,Distrito_Canton_idCanton,Distrito_Canton_Provincia_idProvincia,Descripcion) values('" + identificacion + "'," + Distrito + "," + canton + "," + provincia + ",'" + Descripcion + "')");
            creandoTel = conect.ejecutarInsert("insert into telefono(Persona_idPersona,idTelefono,TipoTelefonio_idTipoTelefonio) values ('" + identificacion + "'," + telefono + "," + tipoTelefono + ")");
            creandoMail = conect.ejecutarInsert("insert into correo (idCorreo,Persona_idPersona,TipoCorreo_idTipoCorreo) values ('" + mail + "','" + identificacion + "'," + tipoMail + ")");
            if (creandoPersona && creandoNacional &&creandoEmpleado && creandoUsuario && creandoDireccion && creandoTel && creandoMail)
            {
                return true;
            }
            return false;
        }


        public bool insertarExtranjero(String identificacion, String nombre, String apellido1, String apellido2, int genero, String Usuario, String Contraseña, int TipoEmpleado, int provincia,int canton,int Distrito, String Descripcion,int activo,int telefono,int tipoTelefono,String mail,int tipoMail)
        {
            bool creandoPersona, creandoExtranjero, creandoUsuario, creandoEmpleado,creandoDireccion,creandoTel,creandoMail;

            creandoPersona = conect.ejecutarInsert("insert into persona (idPersona,TipoPersona_idTipoPersona) values ('" + identificacion + "',2)");
            creandoExtranjero = conect.ejecutarInsert("insert into personaextranjera(Persona_idPersona,Nombre,Apellido1,Apellido2,Genero_idGenero) values ('" + identificacion + "','" + nombre + "','" + apellido1 + "','" + apellido2 + "'," + genero + ")");
            creandoUsuario = conect.ejecutarInsert("insert into usuario(Persona_idPersona,NombreUsuario,Contraseña,TipoUsuario_idTipoUsuario,Activo) values ('" + identificacion + "','" + Usuario + "','" + Contraseña + "'," + TipoEmpleado + ","+activo+")");
            creandoEmpleado = conect.ejecutarInsert("insert into empleado (Usuario_NombreUsuario,Usuario_Persona_idPersona,TipoEmpleado_idTipoEmpleado) values ('" + Usuario + "'," + identificacion + "," + TipoEmpleado + ")");
            creandoDireccion = conect.ejecutarInsert("insert into direccion(Persona_idPersona,Distrito_idDistrito,Distrito_Canton_idCanton,Distrito_Canton_Provincia_idProvincia,Descripcion) values('" + identificacion + "'," + Distrito + ","+canton+","+provincia+",'"+Descripcion+"')");
            creandoTel = conect.ejecutarInsert("insert into telefono(Personona_idPersona,idTelefono,TipoTelefonio_idTipoTelefonio) values ('"+identificacion+"',"+telefono+","+tipoTelefono+")");
            creandoMail = conect.ejecutarInsert("insert into correo (idCorreo,Persona_idPersona,TipoCorreo_idTipoCorreo) values ('"+mail+"','"+identificacion+"',"+tipoMail+")");
            if (creandoPersona && creandoExtranjero && creandoEmpleado && creandoUsuario && creandoDireccion && creandoTel && creandoMail)
            {
                return true;
            }
            return false;
        }
        
       /* public DataTable buscar(int identificacion)
        {
            DataTable dtEmpleados;
            dtEmpleados = conect.ejecutar("select Persona_idPersona from empleado where Persona_idPersona=('" + identificacion + "')"); 
            return dtEmpleados;
        } */


        public DataTable cargarTel()
        {
            DataTable dtTipoTelefonos;
            dtTipoTelefonos = conect.ejecutar("Select idTipoTelefonio,Descripcion from tipotelefonio");
            return dtTipoTelefonos;
        }

        public DataTable cargarMail()
        {
            DataTable dtTipoMail;
            dtTipoMail = conect.ejecutar("Select idTipoCorreo,Descripcion from tipocorreo");
            return dtTipoMail;
        }

        public DataTable cargarProvincia()
        {
            DataTable dtProvincias;
            dtProvincias = conect.ejecutar("Select ID_Provincia,Nombre_Provincia FROM provincia");
            return dtProvincias;
        }
       
        public DataTable cargarCantones(int idProvincia)
        {
            DataTable dtCatones;
            dtCatones = conect.ejecutar("SELECT ID_Canton,ID_Provincia,Nombre_Canton FROM canton where ID_Provincia="+idProvincia+"");
            return dtCatones;
        }

        public DataTable cargarDistritos(int idcanton, int idProvincia)
        {
            DataTable dtDistritos;
            dtDistritos = conect.ejecutar("SELECT ID_Distrito,ID_Canton,ID_Provincia,Nombre_Distrito FROM distrito where ID_Canton="+idcanton+" and ID_Provincia="+idProvincia+"");
            return dtDistritos;

        }
        
        
    }
}

/*  MySql.Data.MySqlClient.MySqlException: 
 *  'You have an error in your SQL syntax; check the manual that 
 *  corresponds to your MySQL server version for the right syntax to use near 
 *  'where ID_Canton='1'' at line 1' */
