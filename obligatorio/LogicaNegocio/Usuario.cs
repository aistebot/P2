using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Usuario
    {
        /* Atributo estatico */
        private static int s_ultimoId = 0;

        /* Atributos */
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _mail;
        private string _contrasenia;


        /* Propiedades */
        public int Id
        {
            get { return _id; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido 
        { 
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public string Contrasenia
        {
            get { return _contrasenia; }
            set { _contrasenia = value;}
        }

        /* Constructores */

        public Usuario()
        {
            this._id = Usuario.s_ultimoId++;
        }

        public Usuario(string unNombre, string unApellido, string unMail, string unaContrasenia)
        {
            this._id = Usuario.s_ultimoId++;
            this._nombre = unNombre;
            this._apellido = unApellido;
            this._mail = unMail;
            this._contrasenia = unaContrasenia;
        }

    }
}
