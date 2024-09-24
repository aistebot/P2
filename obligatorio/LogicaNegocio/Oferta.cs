﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Oferta
    {
        /* Atributo estatico */
        private static int s_ultimoId = 0;

        /* Atributos */
        private int _id;
        private decimal _monto;
        private DateTime _fechaRealizacion;

        /* Propiedades */
        public int Id
        {
            get { return _id; }
        }

        public decimal Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        public DateTime FechaRealizacion
        {
            get { return _fechaRealizacion; }
            set { _fechaRealizacion = value; }
        }
        public Oferta()
        {
            this._id = Oferta.s_ultimoId++;
        }

        public Oferta(decimal unMonto, DateTime unaFechaRealizacion)
        {
            this._id = Oferta.s_ultimoId++;
            this._monto = unMonto;
            this._fechaRealizacion = unaFechaRealizacion;

        }
    }
}
