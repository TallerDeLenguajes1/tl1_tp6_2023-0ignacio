// See https://aka.ms/new-console-template for more information
//------PUNTO 6------
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a = 10;
// b = a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);


//------EJERCICIO 1------
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

//------EJERCICIO 3------
float a, b = 0, c = 0, d = 0;
int aux;
bool control1, control2;
do
{
    Console.WriteLine("CALCULADORA\n1 - Suma\n2 - Resta\n3 - Multiplicacion\n4 - Division\n5 - Valor Absoluto\n6 - Cuadrado\n7 - Raiz Cuadrada\n8 - Seno\n9 - Coseno\n10 - Parte entera de un decimal\n11 - MIN y MAX entre dos numeros\n0 - Salir\nIngrese una opcion: ");
    bool control = int.TryParse(Console.ReadLine(), out aux);
    control1 = true;
    control2 = true;
    if ((aux != 0) && (aux > 0) && (aux < 12) && (control == true))
    {
        do
        {
            if (control1 == false)
            {
                Console.Write("VALOR DESCONOCIDO");
                Console.Write("\nIngrese el valor de a: ");
                control1 = float.TryParse(Console.ReadLine(), out a);
            }else{
                Console.Write("Ingrese el valor de a: ");
                control1 = float.TryParse(Console.ReadLine(), out a);
            }
        } while (control1 != true);

        if ((aux <= 4) || (aux == 11))
        {
            do
            {
                if (control2 == false)
                {
                    Console.Write("VALOR DESCONOCIDO");
                    Console.Write("\nIngrese el valor de b: ");
                    control2 = float.TryParse(Console.ReadLine(), out b);
                }else{
                    Console.Write("Ingrese el valor de b: ");
                    control2 = float.TryParse(Console.ReadLine(), out b);
                }
            } while (control2 != true);
        }

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
            case 5:
                c = Math.Abs(a);
                break;
            case 6:
                c = (float)Math.Pow(a, 2);
                break;
            case 7:
                c = (float)Math.Sqrt(a);
                break;
            case 8:
                c = (float)Math.Sin(a);
                break;
            case 9:
                c = (float)Math.Cos(a);
                break;
            case 10:
                c = (float)Math.Truncate(a);
                break;
            case 11:
                c = Math.Min(a,b);
                d = Math.Max(a,b);
                Console.WriteLine("\nMIN: " + c);
                Console.WriteLine("MAX: " + d);
                break;
            default:
                break;
        }

        if (aux != 11)
        {
            Console.WriteLine("\nRESULTADO: " + c);
        }
    }else{
        if ((aux < 0) || (aux > 12) || (control == false))
        {
            Console.WriteLine("OPCION NO VALIDA");
        }
    }
} while (aux != 0);
Console.WriteLine("EL PROGRAMA FINALIZO");