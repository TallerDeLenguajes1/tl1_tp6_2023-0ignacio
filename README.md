## Ejercicio 4

**Responder las siguientes preguntas en el archivo readme.md**

1. ¿String es una tipo por valor o un tipo por referencia?
2. ¿Qué secuencias de escape tiene el tipo string?
3. ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

### Respuestas

1. String es un tipo de dato por referencia. Esto significa que cuando declaramos una variable de tipo "string", en realidad estamos creando una referencia a un objeto en memoria que contiene al cadena de caracteres.

2. String tiene las siguientes secuencias de escape, las cuales se denotan con el caracter "\" seguido de un caracter especial:

- \": Comillas dobles (")
- \': Comilla simple (')
- \\: Barra invertida ()
- \n: Nueva línea
- \r: Retorno de carro
- \t: Tabulación horizontal
- \b: Retroceso (borra el carácter anterior)
- \f: Avance de página
- \v: Tabulación vertical
- \0: Carácter nulo (valor ASCII 0)

3. 
- @: Cuando se usa el caracter "@" antes de una cadena, lo que ocurre es que estamos indicando que esa cadena es una "cadena literal", esto quiere decir que se ignoran las secuencias de escape, hacien que la cadena se pueda escribir en varias lineas y los caracteres especiales dentro de la cadena se interpretran literalmente.

- $: Cuando se usa el caracter "$" antes de una cadena, se esta indicando que esa cadena es una "cadena interpolada", lo cual permite insertar valores en una cadena o para concatenar varias cadenas.


## Ejercicio 5

### **Expresiones Regulares**

**Busque en diferentes bibliografías que son y cómo funcionan las expresiones
regulares**

1. ¿Funcionan únicamente en C#?
2. ¿En qué casos le parecen útiles? Enuncie al menos 3
3. ¿Cómo se hace uso de estas en C#?


0. Las expresiones regulares nos dan un metodo eficaz y flexible para procesar texto. Son secuencias de caracteres que forman un modelo de búsqueda, permitiendo realizar búsquedas avanzadas, validaciones y manipulaciones de cadenas de texto de manera eficiente. Las expresiones regulares se basan en reglas predefinidas y una sintaxis particular, y se aplican a cadenas de texto para encontrar coincidencias. Las expresiones regulares están compuestas por caracteres que forman un patrón de búsqueda. Estos caracteres tienen un significado especial y se utilizan para representar ciertos elementos o construir reglas de búsqueda más complejas. Algunos de los caracteres especiales más comunes en las expresiones regulares son:

- Caracteres literales: Representan caracteres que se buscan de forma literal. Por ejemplo, la expresión regular abc buscará la secuencia de caracteres "abc" en el texto.

- Metacaracteres: Representan elementos con un significado especial en las expresiones regulares. Por ejemplo, el metacaracter . se utiliza para representar cualquier carácter, excepto el salto de línea. Otros metacaracteres comunes son *, +, ?, [ ], ( ), entre otros.

    1. . (Punto): Coincide con cualquier carácter, excepto un salto de línea.
    2. ^ (Acento circunflejo): Coincide con el inicio de una cadena o línea.
    3. $ (Dólar): Coincide con el final de una cadena o línea.
    4. * (Asterisco): Coincide con cero o más repeticiones del elemento anterior.
    5. + (Signo de más): Coincide con una o más repeticiones del elemento anterior.
    6. ? (Signo de interrogación): Coincide con cero o una repetición del elemento anterior (hace que el elemento sea opcional).
    7. \ (Barra invertida): Se utiliza para escapar metacaracteres especiales y tratarlos literalmente.
    8. [] (Corchetes): Define una clase de caracteres, coincidiendo con cualquier carácter dentro de los corchetes.
    9. [^] (Corchetes negados): Define una clase de caracteres negada, coincidiendo con cualquier carácter que no esté dentro de los corchetes.
    10. - (Guión): Se utiliza dentro de los corchetes para especificar un rango de caracteres.
    11. () (Paréntesis): Agrupa elementos juntos y crea grupos de captura.
    12. | (Barra vertical): Se utiliza para especificar alternativas, coincidiendo con uno de los elementos separados por la barra vertical.
    13. {} (Llaves): Especifica el número exacto o el rango de repeticiones de un elemento anterior.
    14. \b (Límite de palabra): Coincide con un límite de palabra completa.
    15. \d (Dígito): Coincide con un dígito (0-9).
    16. \w (Carácter alfanumérico): Coincide con cualquier carácter alfanumérico (letra o dígito) y el guion bajo (_).
    17. \s (Espacio en blanco): Coincide con cualquier espacio en blanco, incluyendo espacios, tabulaciones y saltos de línea.
    18. \D (No dígito): Coincide con cualquier carácter que no sea un dígito.
    19. \W (No carácter alfanumérico): Coincide con cualquier carácter que no sea alfanumérico.
    20. \S (No espacio en blanco): Coincide con cualquier carácter que no sea un espacio en blanco.

- Cuantificadores: Representan la cantidad de veces que un elemento debe repetirse. Por ejemplo, el cuantificador * indica que el elemento anterior puede repetirse cero o más veces, mientras que + indica una o más repeticiones.

- Clases de caracteres: Representan un conjunto de caracteres posibles. Por ejemplo, [0-9] representa cualquier dígito del 0 al 9, y [a-zA-Z] representa cualquier letra mayúscula o minúscula.

- Secuencias de escape: Permiten buscar caracteres especiales de forma literal. Por ejemplo, \. se utiliza para buscar el carácter punto ".", en lugar de interpretarlo como el metacaracter que representa cualquier carácter.

1. Las expresiones regulares no están limitadas únicamente a C#. Son compatibles con muchos lenguajes de programación y herramientas de manipulación de texto, como Python, JavaScript, Perl, Ruby, entre otros. C# tiene soporte integrado para expresiones regulares a través del namespace System.Text.RegularExpressions.

2. Las expresiones regulares son útiles en muchos casos, 3 ejemplos son:

- Validación de entrada de datos de usuario: Se puede utilizar expresiones regulares para verificar si una cadena de texto cumple con un formato específico, como verificar si un número de teléfono está en un formato válido o si un correo electrónico es válido.

- Búsqueda y manipulación de texto: Se puede buscar y reemplazar patrones específicos dentro de una cadena de texto, como encontrar y cambiar todas las ocurrencias de una palabra en un documento.

- Análisis de registros: Las expresiones regulares son útiles para analizar registros de eventos, permitiéndote extraer información relevante como fechas, nombres de usuario o mensajes de error.

3. En C#, puedes hacer uso de las expresiones regulares a través de la clase Regex del namespace System.Text.RegularExpressions.

- Luego de importar el namespace "System.Text.RegularExpressions", debemos crear una expresion regular utilizando una cadena de texto en la cual armaremos el patron que se desea buscar.

- El siguiente paso es utilizar la clase "Regex" para buscar coincidencias. Esta clase en C# proporciona metodos apra buscar coincidencias de una expresion regular en una cadena de texto. Algunos de los metodos son:

    - Match: Busca la primera coincidencia de la expresión regular en una cadena de texto.
    - Matches: Busca todas las coincidencias de la expresión regular en una cadena de texto y devuelve una colección de coincidencias.
    - IsMatch: Verifica si una cadena de texto cumple con la expresión regular.

Cuando utilizamos el metodo "Matches" obtenemos un objeto "MatchCollection". Este objeto contiene las coincidencias encontradas al buscar una expresion regular en una cadena de texto. 
La clase "MatchCollection" proporciona metodos y propiedades para trabajar con las coincidencias encontradas. Algunas de las propiedades y metodos son:

- Count: Obtiene el número de coincidencias en la colección.
- IsReadOnly: Indica si la colección es de solo lectura, es decir, que no se pueden modificar (si devuelve "true" la coleccion es inmutable, si devuelve "false" la coleccion permite modificaciones).
- Item: Permite acceder a una coincidencia específica en la colección mediante un índice.

Se puede recorrer la coleccion utilizando un bucle "foreach" para acceder a cada objeto "Match" individualmente y obtener informacion sobre cada coincidencia, como el valor encontrado, la posicion de la cadena, etc.