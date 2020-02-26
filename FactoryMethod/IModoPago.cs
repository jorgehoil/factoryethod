using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface IModoPago
    {
        bool validaImporte(double dImporte);
        string obtenerTipoPago();
    }
}
