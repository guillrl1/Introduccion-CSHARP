# Práctica de Unity: Introducción a Scripts, Vectores y Transformaciones

Este repositorio contiene la resolución de los ejercicios prácticos 1-4 en Unity centrados en la programación en C#.

A lo largo de esta práctica, se han trabajado conceptos fundamentales de la API de Unity como el manejo del componente `Transform`, la clase `Vector3`, la búsqueda de GameObjects mediante **Tags**, y la modificación de componentes visuales (`Renderer`).

---

## Ejercicios realizados

A continuación se detallan los ejercicios resueltos.

### Ejercicio 1: Modificación paramétrica de Color
**Objetivo:** Crear un script que modifique aleatoriamente los valores RGB del material de un objeto cada cierto número de frames, configurable desde el Inspector.
* **Resolución:** `Random.Range()`, `GetComponent<Renderer>()`, `Color`, uso de variables públicas, como `framesWait` para definir cuántos frames debe esperar antes de actualizar el color y un contador en el método `Update()` para saber cuándo se llega a dicha cantidad.
* **Prueba de ejecución:** En la siguiente animación se observa cómo el objeto cambia de color automáticamente tras el número de frames establecido.

> ![01](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/01.gif)

---

### Ejercicio 2: Análisis y Operaciones con Vectores
**Objetivo:** Asociar un script a una esfera que defina dos vectores (`Vector3`) públicos para poder darles valor desde el Inspector. El script debe calcular y mostrar matemáticamente la relación entre ellos.
* **Resolución:** Constructores de `Vector3`, `Vector3.magnitude`, `Vector3.Angle()`, `Vector3.Distance()`, y accesos a componentes individuales (`.y` para calcular la altura).
* **Prueba de ejecución:** En la animación se observa cómo al modificar los valores de los Vectores A y B en el Inspector, los cálculos (magnitud, ángulo, distancia y vector más alto) se actualizan y se imprimen a través de `Debug.Log()`.

>![Ejecución Ejercicio 2 - Análisis de Vectores](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/02.gif)

---

### Ejercicio 3: Obtención de la Posición en el Espacio
**Objetivo:** Leer e imprimir en consola la posición actual de un GameObject (la esfera) mediante su componente `Transform`.
* **Resolución:** Diferenciación entre acceder a la propiedad rápida `transform.position` versus realizar la búsqueda exhaustiva del componente con `GetComponent<Transform>()`.
* **Prueba de ejecución:** Salida en consola mostrando las coordenadas X, Y, Z exactas en las que se encuentra la esfera en el momento de darle al Play.

> ![Ejecución Ejercicio 3 - Posición de la Esfera](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/03.gif)

---

### Ejercicio 4: Búsqueda por Etiquetas (Tags) y Cálculo de Distancias
**Objetivo:** Conseguir que la esfera localice de forma autónoma a otros dos objetos de la escena (un cubo y un cilindro) sin necesidad de asignarlos manualmente en el Inspector, para después calcular las distancias entre todos ellos.
* **Resolución:** Uso de `GameObject.FindWithTag()`, creando de esta manera una etiqueta para cada objeto desde la interfaz visual y asignándola a mano. También he hecho uso de `Vector3.Distance()` entre múltiples `Transforms`.
* **Prueba de ejecución:** La consola de Unity muestra las distancias cruzadas: de la esfera al cubo, de la esfera al cilindro, y entre el cubo y el cilindro.

>![Ejecución Ejercicio 4 - Búsqueda por Etiquetas](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/04.gif)

---

##  Herramientas utilizadas
* **Motor:** Unity 3D
* **Lenguaje:** C#
* **Editor de Código:** VS Code
