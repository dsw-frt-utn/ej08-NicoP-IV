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
            int nuevoNumero = 1;
            Product nuevoProducto = new Product { Descripcion = "Ultimo Modelo" };
            Problema3 p3 = new Problema3();
            string resultado = p3.CompararCopias(nuevoNumero, nuevoProducto);
            Console.WriteLine("Resultado: " + resultado);
            Console.WriteLine($"El 'nuevoNumero': {nuevoNumero} (No hubo cambio.)");
            Console.WriteLine($"El 'nuevoProducto': {nuevoProducto.Descripcion} (Hubo cambios.)");
        }
    }
}
