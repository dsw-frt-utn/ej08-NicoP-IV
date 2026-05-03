using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema_2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal totalCalculado = quantity * unitPrice;
            if (quantity <= 0)
            {
                totalCalculado = 0;
            }

            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = totalCalculado
            };
            return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";
        }
    }
}
