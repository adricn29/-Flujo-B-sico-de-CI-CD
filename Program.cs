using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public class Vaso
        {
            public string Tamaño { get; set; }
            public int Cantidad { get; set; }

            public Vaso(string tamaño, int cantidad)
            {
                Tamaño = tamaño;
                Cantidad = cantidad;
            }

            public bool EstaDisponible() => Cantidad > 0;
        }

        public class Azucarero
        {
            public int CantidadAzucar { get; set; }

            public Azucarero(int cantidadInicial)
            {
                CantidadAzucar = cantidadInicial;
            }

            public bool TieneAzucar(int cantidadSolicitada)
            {
                return CantidadAzucar >= cantidadSolicitada;
            }

            public void UsarAzucar(int cantidad)
            {
                if (TieneAzucar(cantidad))
                    CantidadAzucar -= cantidad;
            }
        }

        public class Cafetera
        {
            public int CantidadCafe { get; set; }

            public Cafetera(int cantidadInicial)
            {
                CantidadCafe = cantidadInicial;
            }

            public bool TieneCafe(int cantidad)
            {
                return CantidadCafe >= cantidad;
            }

            public void ServirCafe(int cantidad)
            {
                if (TieneCafe(cantidad))
                    CantidadCafe -= cantidad;
            }
        }
        public class CafeteraTests
        {
            [Fact]
            public void DeberiaServirCafeSiHaySuficiente()
            {
                var cafetera = new Cafetera(10);
                bool resultado = cafetera.TieneCafe(5);
                Assert.True(resultado);
            }

            private class Assert
            {
                internal static void True(bool resultado)
                {
                    throw new NotImplementedException();
                }
            }
        }

    }
}
