// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a = 10;
// b = a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);





// int num = 0;
// string aux2;
// int resto;
// aux2 = Console.ReadLine();
// bool resultado= int.TryParse(aux2, out num);
// if (resultado == true)
// {
//     aux2 = "";
//     while (num > 0)
//     {
//         resto = num % 10; 
//         num = num / 10;
//         aux2 = aux2 + String.Concat(resto); 
//     }
//     Console.WriteLine("El numero invertido es: "+aux2);
// }else{
//     Console.WriteLine("No ingresaste un numero.");
// }




float a, b, c = 0;
int aux;
do
{
    Console.WriteLine("CALCULADORA\n1 - Suma\n2 - Resta\n3 - Multiplicacion\n4 - Division\n0 - Salir\nIngrese una opcion: ");
    int.TryParse(Console.ReadLine(), out aux);
    if (aux != 0)
    {
        Console.Write("Ingrese el valor de a: ");
        float.TryParse(Console.ReadLine(), out a);

        Console.Write("Ingrese el valor de b: ");
        float.TryParse(Console.ReadLine(), out b);
        switch (aux)
        {
            case 1:
                c = a + b;
                break;
            case 2:
                c = a - b;
                break;
            case 3:
                c = a * b;
                break;
            case 4:
                c = a / b;
                break;
            default:
                break;
        }
        Console.WriteLine("\nEl resultado de la operacion entre " + a + " y " + b + " es: " + c);
    }
} while (aux != 0);
Console.WriteLine("\nEL PROGRAMA FINALIZO");

