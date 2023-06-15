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
