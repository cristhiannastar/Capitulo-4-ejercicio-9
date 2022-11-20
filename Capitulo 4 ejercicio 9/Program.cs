class ejer
{


    static public void Main()
    {




        int n3;
        int n4;
        String SoR;
        int result;

        Console.WriteLine("escriba el primero numero: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("escriba el segundo numero: ");
        n4 = int.Parse(Console.ReadLine());

        Console.WriteLine("para sumar digite S y para restar digite R");
        SoR = Console.ReadLine();

        switch (SoR)
        {

            case "S":

                result = n3 + n4;
                Console.WriteLine($"el resultado es:{result}");
                break;

            case "R":

                result = n3 - n4;
                Console.WriteLine($"el resultado es: {result}");
                break;

            default:
                Console.WriteLine("no solecciono suma o resta");
                break;
}

    }
}
