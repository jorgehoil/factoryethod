using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcesadorPagos objProcesador;
            IFabricaMetodoPago iMetodoFabricaPago;
            IModoPago iModoPago;
            Console.WriteLine("Ingrese el Concepto del Pedido");
            string cConcepto = Console.ReadLine();
            Console.WriteLine("Ingrese el método de pago(tarjeta/efectivo):");
            string cMetodoPago = Console.ReadLine();
            Console.WriteLine("Ingrese el importe del pedido:");
            double dImporte = Convert.ToDouble(Console.ReadLine());

            switch (cMetodoPago)
            {
                case "tarjeta":
                    iMetodoFabricaPago = new GeneradoPagoTarjeta();
                    break;
                case "efectivo":
                    iMetodoFabricaPago = new GeneradorPagoEfectivo();
                    break;
                default:
                    iMetodoFabricaPago = new GeneradorPagoEfectivo();
                    break;

            }
            iModoPago = iMetodoFabricaPago.creaModoPago();
            objProcesador = new ProcesadorPagos(iModoPago);
            objProcesador.procesarPagos(dImporte,cConcepto);
            Console.ReadKey();
        }


       


    }
}
