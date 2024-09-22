using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Cliente : Usuario
    {
        /*Atributos*/
        private decimal _saldoBilletera;

        /*Metodos*/
        public decimal SaldoBilletera
        {
            get { return _saldoBilletera; }
            set { _saldoBilletera = value; }
        }

        /*Constructores*/
        public Cliente() : base() { }

        public Cliente(
            string unNombre, 
            string unApellido, 
            string unMail, 
            string unaContrasenia, 
            decimal unSaldo) : base(unNombre, unApellido, unMail, unaContrasenia)
        {
            this._saldoBilletera=unSaldo;
        }
    }
}
