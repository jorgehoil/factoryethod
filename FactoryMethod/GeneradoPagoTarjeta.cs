using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class GeneradoPagoTarjeta : IFabricaMetodoPago
    {
        public IModoPago creaModoPago()
        {
            return new PagoTarjeta();
        }
    }
}
