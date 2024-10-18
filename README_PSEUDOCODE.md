# Prueba técnica
> [!NOTE]  
> Duración 1h

Esta prueba técnica está compuesta por cuatro ejercicios que pretenden medir tus habilidades de lógica de programación. La idea es que realices la prueba del mismo modo en el que llevas a cabo tu trabajo o proyectos personales.

> [!TIP]
>- Busca información en internet, documentación oficial, stackoverflow, etc.
>- Interactua con nosotros para resolver dudas y recibir recomendaciones.

# Ejercicio 1
Escribe un pseudocódigo que muestre por pantalla las 5 ciudades que más veces aparezcan en el array "citiesList". Ordenándolas de mayor a menor según el número de veces que aparezcan en el array.

```c#
string[] citiesList = {
            "madrid",
            "sevilla",
            "toledo",
            "barcelona",
            "sevilla",
            "pontevedra",
            "cuenca",
            "alicante",
            "madrid",
            "toledo",
            "valencia",
            "sevilla",
            "madrid",
            "barcelona",
            "alicante",
            "jaén",
            "cádiz",
            "gijón",
            "sevilla",
            "toledo",
            "cuenca",
            "alicante",
            "sevilla",
            "guadalajara",
            "león"
        };
```

# Ejercicio 2
Escribe un pseudocódigo que resuelva el problema de fizzbuzz. Dado un número entero positivo por parámetro el programa debe cumplir con los siguientes requisitos:
- Cuando el número sea múltiplo de 3, debe sustituirse por la palabra “fizz”, 
- Cuando el número sea múltiplo de 5, debe sustituirse por la palabra “buzz” 
- Cuando el número sea múltiplo de ambos (3 y 5), debe sustituirse por la palabra “fizzbuzz”.
- Cualquier otro número deberá mantenerse sin modificación.

Por último, reutilizar el código anterior para imprimir por pantalla el resultado de nuestro programa desde el 0 hasta el número indicado por parámetro. Por ejemplo, si recibimos el número 20, nuestro programa deberá devolver un resultado similar al siguiente:

```
0, 1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizzbuzz, 16, 17, 18, 19, buzz
```

# Ejercicio 3

Escribe un pseudocódigo que sume todos los dígitos de un número entero positivo.

Ejemplo: 123 = 6

# Ejercicio 4

Explica que hace el código de la clase [Exercise3.cs](src/Exercises/Exercise3/Exercise3.cs). Identifica y corrige los errores en el siguiente código. Si ves algo innecesario, elimínalo.