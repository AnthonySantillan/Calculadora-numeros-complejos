using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematica.Negocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Matematica.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        //suma de dos numeros//

        [TestMethod]
        public void SumaDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 3.1;
            var esperado = 21.1;

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Sumar(primerNumero, segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        //resta de dos numero//
        public void RestaDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 2;
            var esperado = 16;

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Restar(primerNumero, segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        //multiplicacion de dos numeros//
        public void MultiplicacionDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 2;
            var esperado = 36;

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Multiplicar(primerNumero, segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        //Division de dos numeros//
        public void DivisionDeDosNumeros()
        {
            var primerNumero = 18;
            var segundoNumero = 6;
            var esperado = 3;

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Dividir(primerNumero, segundoNumero);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        //Suma de numeros complejos//
        public void SumarComplejos()
        {
            Complejo complejo1 = new Complejo(3, 2);
            Complejo complejo2 = new Complejo(1.5, 6);
            Complejo esperado = new Complejo(4.5, 8);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Sumar(complejo1, complejo2);

            //Assert.AreEqual(esperado.Real, resultado.Real);
            Assert.IsTrue(esperado.Equals(resultado));
        }
        //resta de dos numeros Complejos
        public void RestarComplejos()
        {
            Complejo complejo1 = new Complejo(3, 2);
            Complejo complejo2 = new Complejo(1.5, 6);
            Complejo esperado = new Complejo(4.5, 8);

            var miCalculadora = new Calculadora();
            var resultado = miCalculadora.Restar(complejo1, complejo2);

            Assert.AreEqual(esperado.Real, resultado.Real);
        }
    
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]

        //Division por cero//
        public void DividirPorCero()
        {
            
            var dividendo = 9;
            var divisor = 0;

            var calculadora = new Calculadora() ;
            //_ = calculadora.Dividir(dividendo, divisor);

            Assert.ThrowsException<ArgumentException>(() => calculadora.Dividir(dividendo, divisor));
        }
        [TestMethod]

        //Division de dos numeros//
        public void DivisionDosNumeros()
        {
            var numero1 = 24;
            var numero2 = 4;
            var esperado = 6;

            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(numero1, numero2);

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
      
        public void multiplicacionPorescalar()
        {
            var escalar = 2;

            var complejo = new Complejo(4, 6);

            var resultadoEsperado = new Complejo(8, 12);

            var micalculadora = new Calculadora();

            var resultadoObtenido = micalculadora.multiplicacionEscalar( escalar, complejo);

            Assert.AreEqual(resultadoEsperado.Real, resultadoObtenido.Real);

            Assert.AreEqual(resultadoEsperado.Imaginaria, resultadoObtenido.Imaginaria);

        }
    }
    }

