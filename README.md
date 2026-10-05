# Práctica de Unity: Introducción a Scripts, Vectores y Transformaciones

Este repositorio contiene la resolución de los ejercicios prácticos 1-13 en Unity centrados en la programación en C#.

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

### Hito 5: Desplazamientos Parametrizados mediante Eventos de Entrada
**Objetivo:** Configurar tres objetos en escena para que salten a una posición relativa específica (sumando un vector de desplazamiento a su posición original) cuando el usuario pulsa la barra espaciadora.
* **Resolución:** Se creó un script asignado a cada objeto que guarda su posición inicial (`transform.position`) en el método `Start()`. En el método `Update()`, se utiliza `Input.GetAxis("Jump")` para detectar la pulsación de la barra espaciadora (asignada por defecto a ese eje en Unity). Cuando se detecta, se le suma a la posición original un `Vector3` de desplazamiento configurado públicamente desde el Inspector. Al sumar vectores, el objeto salta matemáticamente a esa nueva coordenada relativa.
* **Prueba de ejecución:** Al pulsar la barra espaciadora, los tres objetos aplican su desplazamiento configurado desde el Inspector simultáneamente.

> ![Ejecución Hito 5 - Salto espacial](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/05.gif)

---

### Hito 6: Lectura de Ejes y Teclas Específicas
**Objetivo:** Calcular una magnitud basada en una variable de velocidad y los valores de los ejes vertical/horizontal, mostrando por consola el resultado solo cuando se detecta la pulsación exacta de una de las flechas direccionales.
* **Resolución:** Se revirtió la configuración del proyecto al **Input Manager (Old)**. En el código, se leen los valores analógicos de -1 a 1 de los ejes usando `Input.GetAxis("Horizontal")` e `Input.GetAxis("Vertical")`. Se multiplica la velocidad por ambos ejes. 
  * *Aclaración sobre el resultado 0:* Es normal que la consola muestre un `0` al pulsar una sola flecha. Si pulsamos solo la flecha arriba, el eje vertical vale 1, pero el horizontal vale 0. Al multiplicar por cero, el total es cero. Para ver números distintos, se deben pulsar dos flechas en diagonal simultáneamente.
  * Se utilizaron condicionales con `Input.GetKey(KeyCode.UpArrow)` (y el resto de flechas) para imprimir el mensaje solo cuando esa tecla física concreta está siendo presionada.
* **Prueba de ejecución:** La consola registra los valores multiplicados, precedidos por el nombre de la flecha específica (ej. "Flecha Arriba: 10").

> ![Ejecución Hito 6 - Ejes y Velocidad](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/06.gif)

---

### Hito 7: Mapeo de Controles Personalizados
**Objetivo:** Utilizar la interfaz del motor para asignar la tecla 'H' a una acción virtual llamada "disparo".
> ![Ejecución Hito 7 - Botón Disparo](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/07.gif)
* **Resolución:** En lugar de usar código para detectar la tecla física 'H', se configuró el **Input Manager** desde *Edit > Project Settings*. Se creó/modificó un eje virtual llamándolo `disparo` y se le asignó la letra `h` en su botón positivo. En el script, se llamó a `Input.GetButtonDown("disparo")`. La diferencia principal es que `GetButtonDown` se activa una sola vez en el frame en el que se pulsa la tecla, ideal para acciones como disparar, en lugar de ejecutarse continuamente mientras se mantiene pulsada.
* **Prueba de ejecución:** La consola muestra el mensaje de confirmación al pulsar la tecla 'H'.

> ![Ejecución Hito 7 - Botón Disparo](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/07_2.gif)

---

### Hito 8: Traslación Continua y Sistemas de Referencia
**Objetivo:** Mover un cubo de forma constante basándose en un vector de dirección y una velocidad, observando el impacto de alterar variables.
* **Resolución:** Se utilizó el método `transform.Translate(moveDirection * speed * Time.deltaTime)`.
  * **1. Duplicar las coordenadas de dirección:** El cubo se desplaza al doble de velocidad (el vector multiplicador es el doble de grande).
  * > ![Ejecución Hito 8 - Translate Continuo](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/08_1.gif)
  * **2. Duplicar la velocidad manteniendo dirección:** Exactamente el mismo resultado que el caso anterior. Al los dos ser factores del mismo producto, da igual cual modifiques, son "intercambiables".
  * > ![Ejecución Hito 8 - Translate Continuo](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/08_2.gif)
  * **3. Usar velocidad menor que 1:** El avance se ralentiza proporcionalmente al multiplicar por una fracción.
  * > ![Ejecución Hito 8 - Translate Continuo](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/08_3.gif)
  * **4. Posición del cubo en Y > 0:** El objeto mantiene su altura inicial flotando durante todo el trayecto (ya que el vector de dirección no tiene componente Y).
  * > ![Ejecución Hito 8 - Translate Continuo](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/08_4.gif)
  * **5. Intercambiar sistema local y mundial:** Al usar `Space.Self` (Local), el objeto avanza según su propia rotación (su "adelante"). Al usar `Space.World` (Mundial), ignora su rotación y se desliza alineado con la cuadrícula absoluta del universo 3D.



---

### Hito 9 y 10: Control de Jugadores y Normalización del Tiempo
**Objetivo:** Mover el cubo (con flechas) y la esfera (con WASD) de forma independiente, asegurando un movimiento fluido e independiente de los FPS.
* **Resolución:** 
  * *Separación de controles:* Si se usara `Input.GetAxis("Horizontal")`, ambos objetos se moverían a la vez porque Unity vincula ese eje tanto a las flechas como a las letras A/D. Para evitarlo, se construyó el valor del eje manualmente comprobando teclas específicas con `Input.GetKey(KeyCode.W)` etc.
  * *Uso de `Time.deltaTime`:* Sin esto, el objeto avanza la velocidad indicada *por cada frame*, haciendo que vaya más rápido en ordenadores potentes. Al multiplicar el vector por `Time.deltaTime` (el tiempo en segundos transcurrido desde el último frame), la velocidad se estabiliza. La variable `speed` pasa a significar "unidades por segundo" en la vida real.
* **Prueba de ejecución:** Ambos objetos se controlan simultáneamente sin interferir, con un movimiento suave.

> ![Ejecución Hito 9 y 10 - Controles Separados y DeltaTime](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/09.gif)

---

### Hito 11: Seguimiento Básico y Normalización Vectorial
**Objetivo:** Hacer que el cubo persiga a la esfera automáticamente. El avance debe ser constante y el cubo no debe alterar su altura.
* **Resolución:** Para obtener el vector de dirección hacia la esfera, se aplica la fórmula matemática de restar vectores: `Destino - Origen` (`esferaObjetivo.position - transform.position`). 
  * Se anula el eje Y (`direccion.y = 0`) para evitar que el cubo se incline hacia arriba o abajo, manteniéndolo a ras de suelo.
  * *Normalización (`.normalized`):* Crucial para el ejercicio. Si el cubo está a 20 metros, el vector resultante tiene una magnitud de 20. Si se multiplica por la velocidad, saldría disparado y se iría frenando al acercarse. Al normalizarlo, el vector mantiene la dirección exacta pero recorta su longitud a `1`, logrando que al multiplicar `1 * speed` la velocidad sea siempre estable sin importar la distancia.
* **Prueba de ejecución:** El cubo avanza hacia la esfera a velocidad fija paseando por el plano X-Z.

> ![Ejecución Hito 11 - Normalización y Seguimiento](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/11.gif)

---

### Hito 12: Encarar al Objetivo (LookAt)
**Objetivo:** Lograr que la cara frontal (eje Z positivo) del cubo apunte siempre hacia la esfera mientras avanza.
* **Resolución:** Se añadió el método `transform.LookAt(esferaObjetivo)` antes de mover el objeto, lo que obliga al cubo a pivotar automáticamente para encarar su objetivo. 
  * *Aclaración:* Al estar el cubo rotando constantemente para mirar a la esfera, su sistema local de coordenadas cambia en cada frame. Por ello, fue obligatorio añadir `Space.World` en el método `Translate`. De lo contrario, el avance se combinaría de forma errónea con la rotación y el cubo se movería en espiral o de lado.
* **Prueba de ejecución:** Al mover la esfera con las teclas WASD, el cubo orbita y gira sobre su centro para mantener a la esfera en su campo de visión frontal.

> ![Ejecución Hito 12 - Uso de LookAt](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/12.gif)

---

### Hito 13: Controles de Vehículo (Giro y Avance Frontal)
**Objetivo:** Crear un control estilo tanque/coche, donde el eje horizontal rota el objeto y este avanza siempre hacia adelante.
* **Resolución:** Se separó el giro del avance.
  * El giro se aplicó con `transform.Rotate()`, aplicando la lectura del eje horizontal al eje Y (el eje vertical sobre el que pivota el objeto como una peonza).
  * El avance se realizó usando `transform.forward`. La diferencia con `Vector3.forward` (que siempre es el norte absoluto 0,0,1) es que `transform.forward` es dinámico: representa hacia dónde apunta el morro del objeto en ese preciso instante tras haber rotado.
  * Se incluyó `Debug.DrawRay` para trazar una línea visible en la ventana *Scene* desde el centro del objeto hacia su frente, facilitando la depuración visual.
* **Prueba de ejecución:** El objeto rota sobre sí mismo con las teclas laterales y avanza de frente.

> ![Ejecución Hito 13 - Movimiento Tipo Vehículo](https://github.com/guillrl1/Introduccion-CSHARP/blob/main/gifs/13.gif)

---

## Guía de Referencia Rápida de Unity

Durante esta práctica se han utilizado los siguientes componentes y clases fundamentales de la API de Unity:

### [`Vector3`](https://docs.unity3d.com/ScriptReference/Vector3.html)
Es una estructura matemática que representa puntos y direcciones en un espacio 3D mediante tres coordenadas (X, Y, Z).
* **[`new Vector3(x, y, z)`](https://docs.unity3d.com/ScriptReference/Vector3-ctor.html)**: Constructor para crear un vector desde cero.
* **[`.magnitude`](https://docs.unity3d.com/ScriptReference/Vector3-magnitude.html)**: Propiedad que devuelve la longitud total del vector (la distancia desde el origen 0,0,0 hasta su punto final).
* **[`.normalized`](https://docs.unity3d.com/ScriptReference/Vector3-normalized.html)**: Propiedad que devuelve el mismo vector manteniendo su dirección, pero reduciendo su magnitud (longitud) exactamente a 1. Vital para mantener velocidades constantes.
* **[`Vector3.Distance(A, B)`](https://docs.unity3d.com/ScriptReference/Vector3.Distance.html)**: Método estático que calcula la distancia real entre dos posiciones.
* **[`Vector3.Angle(A, B)`](https://docs.unity3d.com/ScriptReference/Vector3.Angle.html)**: Método que calcula el ángulo más corto entre dos vectores.

### [`Transform`](https://docs.unity3d.com/ScriptReference/Transform.html)
El componente más importante de Unity. Todos los GameObjects tienen uno. Controla la Posición, Rotación y Escala del objeto en el mundo. Se accede a él en los scripts escribiendo `transform` (en minúscula).
* **[`.position`](https://docs.unity3d.com/ScriptReference/Transform-position.html)**: Almacena y permite modificar la posición global del objeto (es un Vector3).
* **[`.forward`](https://docs.unity3d.com/ScriptReference/Transform-forward.html)**: Devuelve un Vector3 normalizado que apunta hacia donde está mirando el eje Z positivo (el frente) del objeto en ese instante.
* **[`.Translate(vector, espacio)`](https://docs.unity3d.com/ScriptReference/Transform.Translate.html)**: Método que desplaza el objeto gradualmente. Puede ejecutarse usando el espacio local (`Space.Self`) o el espacio mundial (`Space.World`).
* **[`.Rotate(x, y, z)`](https://docs.unity3d.com/ScriptReference/Transform.Rotate.html)**: Método que hace rotar al objeto sobre sus propios ejes.
* **[`.LookAt(objetivo)`](https://docs.unity3d.com/ScriptReference/Transform.LookAt.html)**: Método que rota instantáneamente el objeto para que su eje frontal apunte directamente hacia la posición (Transform) de otro objeto.

### [`Input`](https://docs.unity3d.com/ScriptReference/Input.html)
La clase encargada de gestionar las entradas del jugador (teclado, ratón, mandos).
* **[`.GetAxis("NombreEje")`](https://docs.unity3d.com/ScriptReference/Input.GetAxis.html)**: Lee un eje configurado en el Input Manager. Devuelve un valor decimal suave entre -1 y 1. Ideal para joysticks o movimiento fluido.
* **[`.GetButtonDown("NombreBoton")`](https://docs.unity3d.com/ScriptReference/Input.GetButtonDown.html)**: Devuelve `true` únicamente en el frame exacto en el que el jugador presiona el botón. No se repite si se mantiene pulsado.
* **[`.GetKey(KeyCode.Tecla)`](https://docs.unity3d.com/ScriptReference/Input.GetKey.html)**: Detecta directamente hardware físico. Devuelve `true` de forma continua mientras la tecla especificada (ej. `KeyCode.UpArrow`) se mantenga presionada.

### [`Time.deltaTime`](https://docs.unity3d.com/ScriptReference/Time-deltaTime.html)
No es una clase, sino una propiedad estática de la clase [`Time`](https://docs.unity3d.com/ScriptReference/Time.html). Devuelve el tiempo en segundos que ha tardado en procesarse el último frame. 
* **Utilidad:** Se multiplica por los vectores de movimiento o rotación dentro del `Update()`. Sirve para independizar la lógica del juego de la potencia del ordenador, convirtiendo valores de "unidades por frame" a "unidades por segundo real".

##  Herramientas utilizadas
* **Motor:** Unity 3D
* **Lenguaje:** C#
* **Editor de Código:** VS Code
