using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PagoEfectivo : IModoPago
    {
        public string obtenerTipoPago()
        {
            return "en efectivo";
        }

        public bool validaImporte(double dImporte)
        {
            bool lAutorizado = false;
            if (dImporte <= 5000)
                lAutorizado = true;
            return lAutorizado;
        }
    }
}
