using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ProcesadorPagos : IProcesadorPagos
    {
        IModoPago iFabricaMetodo;

        public void procesarPagos(double dImporte, string cConcepto)
        {
            bool lAutorizado=iFabricaMetodo.validaImporte(dImporte);
            string cTipoPago = iFabricaMetodo.obtenerTipoPago();
            Console.WriteLine("Pedido {0} con importe {1} {2} fue {3}", cConcepto, dImporte, cTipoPago, (lAutorizado?"autorizado":"rechazado"));

        }

        public ProcesadorPagos(IModoPago iFabricaMetodo)
        {
            this.iFabricaMetodo = iFabricaMetodo;
        }

        

    }
}
