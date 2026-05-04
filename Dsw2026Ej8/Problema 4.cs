using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema_4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double suma = 0;
            int contador = 0;

            if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10)
            {
                suma += (double)nota1.Value;
                contador++;
            }

            if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10)
            {
                suma += (double)nota2.Value;
                contador++;
            }

            if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10)
            {
                suma += (double)nota3.Value;
                contador++;
            }

            if (contador == 0) return 0;

            return suma / contador;
        }
    }
}
