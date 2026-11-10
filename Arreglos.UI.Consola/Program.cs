using Arreglos.Logica;

Console.WriteLine("Operaciones de pila");

Console.WriteLine("Arreglo\n");
//MiArreglo oMiArreglo = new MiArreglo(5);
//try
//{
//    oMiArreglo.Agregar(7);
//    oMiArreglo.Agregar(-2);
//    oMiArreglo.Agregar(8);
//    Console.WriteLine(oMiArreglo);

//    Console.WriteLine("Insertar 500 en la posición 1");
//    Console.ReadKey();
//    oMiArreglo.Insertar(500, 1);
//    Console.WriteLine(oMiArreglo);

//    Console.WriteLine("Eliminar 500 en la posición 1");
//    Console.ReadKey();
//    oMiArreglo.Eliminar(1);
//    Console.WriteLine(oMiArreglo);



//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}




MiArreglo oMiArreglo = new(100);



try
{
    Console.WriteLine("\nArreglo\n");
    oMiArreglo.Llenar();
    Console.WriteLine(oMiArreglo);
    Console.ReadKey();

    Console.WriteLine("\nPares\n");
    var verPares =oMiArreglo.ObtenerPares();
    Console.WriteLine(verPares);
    Console.ReadKey();


    Console.WriteLine("Pares Ordenados\n");
    verPares.Ordenar(true);
    Console.WriteLine(verPares);
    Console.ReadKey();


    Console.WriteLine("\nPrimos\n");
    var verPrimos = oMiArreglo.ObtenerPrimos();
    Console.WriteLine(verPrimos);
    Console.ReadKey();

    Console.WriteLine("Primos Ordenados\n");
    verPrimos.Ordenar(true);
    Console.WriteLine(verPrimos);
    Console.ReadKey();


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


//Console.WriteLine("Arreglo desordenado\n");
//Console.WriteLine(oMiArreglo);

//Console.WriteLine("Arreglo ordenado ascendente\n");
//oMiArreglo.Ordenar();
//Console.WriteLine(oMiArreglo);

//Console.WriteLine("Arreglo ordenado descendente\n");
//oMiArreglo.Ordenar(false);
//Console.WriteLine(oMiArreglo);


Console.ReadKey();