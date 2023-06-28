using System.Text.RegularExpressions;
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

//------EJERCICIO 4------

// Console.WriteLine("Ingrese una cadena de texto: ");
// string? cad1 = Console.ReadLine();

// Console.WriteLine("1. La longitud de la cadena es: " + cad1.Length);
// Console.WriteLine("Ingrese otra cadena de texto: ");
// string? cad2 = Console.ReadLine();
// Console.WriteLine("2. Cadenas 1 y 2 concatenadas: " + string.Concat(cad1, cad2));
// Console.WriteLine("3. Subcadena de cad1: " + cad1.Substring(0, cad1.Length/2));
// Console.WriteLine("5. Cad1 caracter por caracter: ");
// foreach (char caracter in cad1)
// {
//     Console.WriteLine(caracter);
// }
// Console.WriteLine("6. Ingrese otra cadena de texto: ");
// string? cad3 = Console.ReadLine();
// Console.WriteLine("---Ingrese una palabra a buscar en la cadena: ");
// string? palabra = Console.ReadLine();
// if (cad3.Contains(palabra))
// {
//     Console.WriteLine($"---La palabra {palabra} esta contenida en la cad3: {cad3}");
// }else{
//     Console.WriteLine($"---La palabra {palabra} no esta contenida en la cad3: {cad3}");
// }
// Console.WriteLine($"7. Cad3 MAYUSCULA: {cad3.ToUpper()}");
// Console.WriteLine($"---Cad3 minuscula: {cad3.ToLower()}");
// Console.WriteLine("8. Ingrese otra cadena de texto separada por '-': ");
// string? cad4 = Console.ReadLine();
// string[] partes = cad4.Split("-");
// string? cad5 = string.Join(" ", partes);
// Console.WriteLine($"---Cad4 'sin separar': {cad4}");
// Console.WriteLine($"---Cad5 'separada': {cad5}");
// Console.WriteLine("8. Ingrese una funcion matematica simple de una operacion: ");
// string? operacion = Console.ReadLine();
// int a = 0;
// int b = 0;
// if (operacion.Contains('+'))
// {
//     string[] listaOp = operacion.Split('+');
//     int.TryParse(listaOp[0], out a);
//     int.TryParse(listaOp[1], out b);
//     Console.WriteLine("---La suma entre "+a+" y "+b+" es igual a "+(a + b)+".");
// }
// if (operacion.Contains('-'))
// {
//     string[] listaOp = operacion.Split('-');
//     int.TryParse(listaOp[0], out a);
//     int.TryParse(listaOp[1], out b);
//     Console.WriteLine("---La resta entre "+a+" y "+b+" es igual a "+(a - b)+".");
// }
// if (operacion.Contains('*'))
// {
//     string[] listaOp = operacion.Split('*');
//     int.TryParse(listaOp[0], out a);
//     int.TryParse(listaOp[1], out b);
//     Console.WriteLine("---La multiplicacion entre "+a+" y "+b+" es igual a "+(a * b)+".");
// }
// if (operacion.Contains('/'))
// {
//     string[] listaOp = operacion.Split('/');
//     int.TryParse(listaOp[0], out a);
//     int.TryParse(listaOp[1], out b);
//     Console.WriteLine("---La division entre "+a+" y "+b+" es igual a "+(a / b)+".");
// }

//------EJERCICIO 5------
//Construir un programa que permita identificar de forma sencilla si la cadena ingresada es una dirección web y otro que una cadena ingresada sea un mail válido.
//https://www.youtube.com/watch?v=FKIe-1fUS6g&list=PLWYKfSbdsjJgCXQ_Y_d76x-v9hR8Tr_1v&index=8
Console.WriteLine("Ingrese un direccion web: ");
string? cadena = Console.ReadLine();
string pattern = @"^(https?)://[^\s/$.?#].[^\s]*$";
bool esUrl = Regex.IsMatch(cadena, pattern);
if (esUrl)
{
    Console.WriteLine("La cadena ingresada es una dirección web válida.");
}else{
    Console.WriteLine("La cadena ingresada no es una dirección web válida.");
}

Console.WriteLine("Ingrese un mail: ");
cadena = Console.ReadLine();
pattern = @"^[^\s._\-][a-zA-Z0-9._+-]+[^\s._\-]@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
bool esMail = Regex.IsMatch(cadena, pattern);
if (esMail)
{
    Console.WriteLine("La cadena ingresada es un mail valido.");
}else{
    Console.WriteLine("La cadena ingresada no es un mail valido.");
}