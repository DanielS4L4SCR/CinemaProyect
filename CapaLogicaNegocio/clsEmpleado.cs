using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaNegocios
{
    public class clsEmpleado

    {
        public bool insertarNacional(String identificacion, String nombre, String apellido1, String apellido2, int genero,String Usuario, String Contraseña,int TipoEmpleado, int provincia, int canton, int Distrito, String Descripcion,int activo, int telefono, int tipoTelefono, String mail, int tipoMail)
        {
            return new CapaDatos.ClsEmpleado().insertarNacional(identificacion, nombre, apellido1, apellido2, genero, Usuario, Contraseña,TipoEmpleado, provincia, canton, Distrito, Descripcion,activo,telefono,tipoTelefono,mail,tipoMail);

        }


        public bool insertarExtranjero(String identificacion, String nombre, String apellido1, String apellido2, int genero, String Usuario, String Contraseña,int TipoEmpleado, int provincia, int canton, int Distrito, String Descripcion,int activo, int telefono, int tipoTelefono, String mail, int tipoMail)
        {
            return new CapaDatos.ClsEmpleado().insertarExtranjero(identificacion, nombre, apellido1, apellido2, genero, Usuario, Contraseña,TipoEmpleado,provincia,canton,Distrito,Descripcion,activo, telefono, tipoTelefono, mail, tipoMail);
        }

        public DataTable LlenarCamposTel()
        {
            CapaDatos.ClsEmpleado Telefono = new CapaDatos.ClsEmpleado();
            return Telefono.cargarTel();
        }

        public DataTable LlenarCamposMail()
        {
            CapaDatos.ClsEmpleado Mail = new CapaDatos.ClsEmpleado();
            return Mail.cargarMail();
        }

        public DataTable LlenarCamposProv()
        {
            CapaDatos.ClsEmpleado provincia = new CapaDatos.ClsEmpleado();
            return provincia.cargarProvincia();
        }


        public DataTable LlenarCamposCan(int idProvincia)
        {
            CapaDatos.ClsEmpleado canton = new CapaDatos.ClsEmpleado();
            return canton.cargarCantones(idProvincia);
        }

        public DataTable LlenarCamposDis(int idCan, int idProv)
        {
            CapaDatos.ClsEmpleado distrito = new CapaDatos.ClsEmpleado();
            return distrito.cargarDistritos(idCan, idProv);
        }
    }
}
