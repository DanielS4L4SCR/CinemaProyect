﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaDatos
{
    public class ClsLogin
    {
        public DataTable CargarDatos(String user, String password)
        {
            CapaDatos.ClsConexion conexion = new ClsConexion();
            DataTable dtUsarios;

            dtUsarios = conexion.ejecutar("Select NombreUsuario from Usuario where NombreUsuario='" + user + "' and Contraseña='" + password + "'");
            return dtUsarios;
        }
    }
}
