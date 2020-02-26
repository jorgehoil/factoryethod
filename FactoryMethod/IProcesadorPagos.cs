using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface IProcesadorPagos
    {
        void procesarPagos(double dImporte, string cConcepto);
        
    }
}
