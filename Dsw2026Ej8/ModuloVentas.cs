using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public abstract class Sale
    {
        public decimal Importe { get; set; }
        public virtual decimal CalculateTotal()
        {
            return Importe;
        }
    }
    public class RetailSale : Sale
    {
        public override decimal CalculateTotal() => Importe;
    }
    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal() => Importe * 0.9m;
    }
}
