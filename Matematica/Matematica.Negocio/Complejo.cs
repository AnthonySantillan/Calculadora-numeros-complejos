using System;
using System.Diagnostics.CodeAnalysis;

namespace Matematica.Negocio
{
    public class Complejo : IEquatable<Complejo>
    {


        public Complejo(double real, double imaginaria)
        {
            this.Real = real;
            this.Imaginaria = imaginaria;

        }

        public double Imaginaria { get; internal set; }
        public double Real { get; internal set; }

        public bool Equals([AllowNull] Complejo other)
        {
            //lo mismo pero mas barato
            return Real == other.Real && Imaginaria == other.Imaginaria;
            /*if normal
            if (Real == other.Real && Imaginaria == other.Imaginaria)
           
                return true;
                return false;
                 */
        }
    }  
 }