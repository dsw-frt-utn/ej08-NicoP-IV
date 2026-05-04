namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROBLEMA 1, VALORES DE PRUEBA
            //string resultado = ProductHelper.ObtenerEtiquetaProducto(60680, "Leche Entera", 1800.64m);
            //Console.WriteLine(resultado);

            //PROBLEMA 2, VALORES DE PRUEBA
            //Problema_2 p2 = new Problema_2();
            //Console.WriteLine("1: " + p2.CrearResumenVenta(606, "Procesador", 1, 290000));
            //Console.WriteLine("2: " + p2.CrearResumenVenta(608, "Mouse", -2, 8000));
            //Console.WriteLine("3: " + p2.CrearResumenVenta(608, "Parlante", 4, 1500));

            //PROBLEMA 3, VALORES DE PRUEBA
            //int nuevoNumero = 1;
            //Product nuevoProducto = new Product { Descripcion = "Ultimo Modelo" };
            //Problema3 p3 = new Problema3();
            //string resultado = p3.CompararCopias(nuevoNumero, nuevoProducto);
            //Console.WriteLine("Resultado: " + resultado);
            //Tengo Dudas

            //PROBLEMA 4, VALORES DE PRUEBA
            //Problema4 p4 = new Problema4();
            //double res1 = p4.CalcularPromedio(2, 10, 6);
            //Console.WriteLine($"Caso 1 (8, 7, 6): {res1}"); 
            //double res2 = p4.CalcularPromedio(8, null, 9);
            //Console.WriteLine($"Caso 2 (3, null, 5): {res2}");
            //double res3 = p4.CalcularPromedio(5, 6, -2);
            //Console.WriteLine($"Caso 3 (10, 4, -2): {res3}");
            //double res4 = p4.CalcularPromedio(null, null, null);
            //Console.WriteLine($"Caso 4 (null, null, null): {res4}");


            //PROBLEMA 5, VALORES DE PRUEBA
            //Problema5 p5 = new Problema5();
            //Sale minorista = new RetailSale { Importe = 15000 };
            //Console.WriteLine($"Venta Minorista: {p5.ObtenerImporteFinal(minorista)}");
            //Sale mayorista = new WholesaleSale { Importe = 2000 };
            //Console.WriteLine($"Venta Mayorista: {p5.ObtenerImporteFinal(mayorista)}");

            //PROBLEMA 6, VALORES DE PRUEBA
            Problema_6 p6 = new Problema_6();
            string prueba = "ab 6068 x ";
            Console.WriteLine($"Original: '{prueba}'");
            Console.WriteLine($"Normalizado: {p6.NormalizarCodigoProducto(prueba)}");
            Console.WriteLine($"null: {p6.NormalizarCodigoProducto(null)}");
        }
    }
}
