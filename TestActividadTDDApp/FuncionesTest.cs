
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public class FuncionesTest
    {
        [TestMethod]
        public void CalcularFactorial_Negativo_DevuelveMenosUno()
        {
            Funciones funciones = new Funciones();

            long resultado = funciones.CalcularFactorial(-1);

            Assert.AreEqual(-1L, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cero_DevuelveUno()
        {
            Funciones funciones = new Funciones();

            long resultado = funciones.CalcularFactorial(0);

            Assert.AreEqual(1L, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Tres_DevuelveSeis()
        {
            Funciones funciones = new Funciones();

            long resultado = funciones.CalcularFactorial(3);

            Assert.AreEqual(6L, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cinco_DevuelveCientoVeinte()
        {
            Funciones funciones = new Funciones();

            long resultado = funciones.CalcularFactorial(5);

            Assert.AreEqual(120L, resultado);
        }
    }
}
