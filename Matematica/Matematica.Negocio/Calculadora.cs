using System.Numerics;

namespace Matematica.Negocio
{
    public class Calculadora
    {
        public Calculadora()
        {
        }
        //sumar
        public double Sumar(double primerNumero, double segundoNumero)
        {
            return primerNumero + segundoNumero;
        }
        //suma de complejos
        public Complejo Sumar(Complejo primerComplejo, Complejo segundoComplejo)
        {
            var parteReal = primerComplejo.Real + segundoComplejo.Real;
            var parteImaginaria = primerComplejo.Imaginaria + segundoComplejo.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
            
        }
        //dividir
        public double Dividir(double dividendo, double divisor)
        {
            if(divisor == 0)
            {
                throw new System.ArgumentException();
            }
            return dividendo / divisor;
        }
        //resta 
        public object Restar(int primerNumero, int segundoNumero)
        {
            return primerNumero - segundoNumero;
        }
        //resta de complejos
        public Complejo Restar(Complejo primerComplejo, Complejo segundoComplejo)
        {
            var parteReal = primerComplejo.Real - segundoComplejo.Real;
            var parteImaginaria = primerComplejo.Imaginaria - segundoComplejo.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;

        }
        //multiplicar 
        public object Multiplicar(int primerNumero, int segundoNumero)
        {
            return primerNumero * segundoNumero;
        }
        //multiplicacion de complejos
        public Complejo Multiplicar(Complejo primerComplejo, Complejo segundoComplejo)
        {
            var parteReal = primerComplejo.Real * segundoComplejo.Real;
            var parteImaginaria = primerComplejo.Imaginaria * segundoComplejo.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;

        }

        public Complejo multiplicacionEscalar(double numero, Complejo primerNumero)
        {
            var parteReal = numero * primerNumero.Real;

            var parteImaginaria = numero * primerNumero.Imaginaria;

            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
        }


    }
}