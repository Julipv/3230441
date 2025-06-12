do
{
    Console.WriteLine("INGRESE PRIMER NUMERO ENTERO");
    var N1 = (Console.ReadLine());

    if (int.TryParse(N1, out int N1int))
    {

        Console.WriteLine("INGRESE EL SEGUNDO NUMERO ENTERO");
        var N2 = (Console.ReadLine());

        if (int.TryParse(N2, out int N2int)) ;
        {
            Console.WriteLine("INGRESE EL SEGUNDO NUMERO ENTERO");

        }
        if (N1int % N2int == 0)
        {
            Console.WriteLine($"EL NUMERO {N1} ES MULTIPLO DE {N2}");
        }

        else
        {

            Console.WriteLine($"EL NUMERO {N1} NO ES MULTIPLO DE {N2}");
        }
       
    }

    else
    {
        Console.WriteLine("DEBES INGRESAR UN NUMERO ENTERO");
  
    }
}
while (true);
