using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class GeneradorPagoEfectivo : IFabricaMetodoPago
    {
        public IModoPago creaModoPago()
        {
            return new PagoEfectivo();
        }
    }
}
