using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        public string? Descripcion { get; set; }
        public void ModificarDescripcion(string nuevaDesc) => Descripcion = nuevaDesc;
    }
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int valorDeLaCopia = originalValue;
            valorDeLaCopia++;

            Product copiaReferencia = product;
            copiaReferencia.ModificarDescripcion("Copia Modificada");

            return $"{originalValue}-{valorDeLaCopia}-{product.Descripcion}";
        }
    }
}
