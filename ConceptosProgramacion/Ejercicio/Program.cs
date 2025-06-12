
do
{
    Console.WriteLine("INGRESE PRIMER NUMERO ENTERO");
  var N1= int.Parse(Console.ReadLine());
    Console.WriteLine("INGRESE EL SEGUNDO NUMERO ENTERO");
    var N2 = int.Parse(Console.ReadLine());
    Console.WriteLine("INGRESE EL TERCER NUMERO ENTERO");
    var N3 = int.Parse(Console.ReadLine());

    if (N1 > N2 & N2 > N3)

    { 
        Console.WriteLine($"EL NUMERO MAYOR ES {N1}");
        Console.WriteLine($"EL NUMERO  DEL MEDIO ES {N2}");
        Console.WriteLine($"EL NUMERO MENOR ES {N3}");
    }

    else if (N1 > N3 & N3 > N2)
    {
        Console.WriteLine($"EL NUMERO MAYOR ES {N1}");
        Console.WriteLine($"EL NUMERO DEL MEDIO ES {N3}");
        Console.WriteLine($"EL NUMERO MENOR ES {N1}");
    }

    else if (N2 > N1 & N1 > N3)
    {
        Console.WriteLine($"EL NUMERO MAYOR ES {N2}");
        Console.WriteLine($"EL NUMERO DEL MEDIO ES {N1}");
        Console.WriteLine($"EL NUMERO MENOR ES {N3}");
    }
    else if (N2 > N3 & N3 > N1)
    {
        Console.WriteLine($"EL NUMERO MAYOR ES {N2}");
        Console.WriteLine($"EL NUMERO DEL MEDIO ES {N3}");
        Console.WriteLine($"EL NUMERO MENOR ES {N1}");
    }
    else if (N3 > N1 & N1 > N2)
    {
        Console.WriteLine($"EL NUMERO MAYOR ES {N3}");
        Console.WriteLine($"EL NUMERO DEL MEDIO ES {N1}");
        Console.WriteLine($"EL NUMERO MENOR ES {N2}");
    }
    else
    {
        Console.WriteLine($"EL NUMERO MAYOR ES {N3}");
        Console.WriteLine($"EL NUMERO DEL MEDIO ES {N2}");
        Console.WriteLine($"EL NUMERO MENOR ES {N1}");
    }
}
    while (true) ;