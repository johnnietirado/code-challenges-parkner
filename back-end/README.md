# Parkner Back End Challenge

[Instrucciones para instalar y correr código](#instrucciones)

Este reto tiene 3 partes y una opcional:

1. [Completar varios End-points que no están programados](#parte-uno)
  - Este paso te ayudara a familiarizarte con el código y cómo funciona el API.
  - Las soluciones deberían de tomar entre 3-5 lineas de código.
  - Estos tendrán dentro de su cuerpo una excepción de tipo `NotImplementedException` y contienen las instrucciones.
  
2. [Crear un nuevo end-point para obtener informacion de sesiones](#parte-dos).
  - Aquí debes crear un nuevo end-point siguiendo el estilo de la API (Crear un Repository, Service y Controller).
  - Esta parte deberia de tomarte 30-45 minutos
  
3. [Usar MongoDB driver y Aggregations](#parte-tres)
  - Esta parte pondrá en prueba tus habilidades de manipulación de data y queries de MongoDB.
  - Se busca un conocimiento de filtros de MongoDB y funciones del aggregation pipeline.
  
4. [**OPCIONAL** - Diviértete con la API de Star Wars](#parte-cuatro)
  - Esta parte es opcional y **no contara en contra si no se hace.**
  - Queremos ver si puedes obtener información de una API, manipularla y presentarla al usuario final. 
  
## Parte Uno 📚

Bienvenido a la primera parte, la meta es familiarizarte con el código. Este proyecto tiene un formato muy similar al API en producción de Parkner.

Un resumen breve en como está dividida el API.
  - **Controllers**: Punto de acceso a la API (End-points)
  - **Services**: Modulos donde se manipula la información de un *Modelo* con conexión a un Repository.
  - **Repository**: Conexión directa a la base de datos. Aquí es donde se hace cualquier operación con la base de datos.
  - **Models**: Las clases que representan los diferentes objetos en la applicación y que estan asociados con cada documento en la base de datos.
  
El flujo de información es el siguiente:

El cliente llama al API que usa la URL para llamar un **Controller** que luego llama un **Service**. El service puede obtener información de un **Repository** y regresar información al **Controller**.

Un ejemplo puede verse en el *GET* Method en `UserController.cs`

Hay 3 metodos que deben ser completados en esta etapa:

1. `GetUser` en `UserService.cs`
2. `GetLot` en `LotController.cs`
2. `GetLot` en `LotRepository.cs`

Si has implementado correctamente los métodos las siguientes URL te regresaran valores en formato JSON

1. [https://localhost:5001/api/users/5d2a65851c9d440000bbf57b](https://localhost:5001/api/users/5d2a65851c9d440000bbf57b)
2. [https://localhost:5001/api/lots](https://localhost:5001/api/lots)
3. [https://localhost:5001/api/lots/5d2a78e17601b1c2f672d2a6](https://localhost:5001/api/lots/5d2a78e17601b1c2f672d2a6)

¡Con esto terminas la parte uno 🤓!

## Parte Dos 💻

Ahora crearas tu propio **Controller**, **Service** y **Repository**.

Crea un Controller que tenga los siguientes métodos:

1. `Get`
2. `GetSession`
3. `GetRevenueByMonth` (Se usará en la parte tres)
  - ruta: `sessions/report`
4. `GetSessionReportForLot` (Se usará en la parte tres)
  - ruta: `sessions/report/{lotId}`

Debería de ser bastante obvio basado en la parte uno que el `Get` method obtiene todas las sesiones y el `GetSession` solo obtiene UNA sesión.

**IMPORTANTE**

El nombre del COLLECTION es **sessions**

Una vez que hayas implementado lo de arriba deberían de funcionar los siguientes URL:

1. [https://localhost:5001/api/sessions](https://localhost:5001/api/sessions/5d2a65851c9d440000bbf57b)
2. [https://localhost:5001/api/sessions/5d2a65851c9d440000bbf57b](https://localhost:5001/api/sessions/5d2a65851c9d440000bbf57b)

Si pudiste visualizar las sesiones has completado la segunda parte. 🙌🏼

## Parte Tres 📐

La última parte del reto va a poner a prueba tus habilidades de MongoDB.

1 - Primero filtremos las sesiones. 

Deberíamos poder pasar query parameters a `/sessions` para obtener sesiones que están activas. Al pasar el query paramater `active=true` debería de regresar 3 sesiones. **Una sesión esta activa cuando no tiene una fecha final**.

2 - Queremos ver nuestros ingresos por mes

Usando el endpoint `report` y la función `GetRevenueByMonth` debería de devolverme un JSON con el siguiente formato:

``` js
[
    { "date": "2019-01-01", "total": 100, "payouts": 74, "cut": 26 },
    { "date": "2019-02-01", "total": 75, "payouts": 60, "cut": 15 }
]
```

La fecha es el mes en el cual se creó la sesión, el total es la suma del monto total de una sesión. El `payout` es el monto que se le da a el dueño del estacionamiento y el `cut` es lo que queda para Parkner.

Si has implementado el end-point este url debería de regresar un JSON con el formato de arriba:

* [https://localhost:5001/api/sessions/report](https://localhost:5001/api/sessions/report)

3 - Queremos ver los ingresos para solo un estacionamiento

Ahora juntaremos los pasos 1 y 2. Para el endpoint `sessions/report/{lotId}` queremos obtener la información en el mismo formato que arriba pero para solo para el estacionamiento con el **id** ingresado.

Si has implementado el end-point este url debería de regresar un JSON con la información correcta:

* [https://localhost:5001/api/sessions/report/5d2a78e17601b1c2f672d2a6](https://localhost:5001/api/sessions/report/5d2a78e17601b1c2f672d2a6)

## Parte Cuatro - OPCIONAL 🚀

La última parte del reto es opcional, solo hazla si tienes el tiempo. 

Buscamos ver tu creatividad y cómo manejar información de otra API.

Usando [SWAPI](https://swapi.co/) crea un end-point `/star-wars` que regrese alguna información sobre el universo de Star Wars.

Para hacer los requests a otra API usa [RestSharp](http://restsharp.org/). Ya viene con el proyecto así que no se tiene que instalar.

Una vez termines todas las partes **mandar el código en formato .ZIP** a [johnnie@parkner.pe](mailto:johnnie@parkner.pe)

---
## Instrucciones para correr proyecto

1. Instalar [VSCode](https://code.visualstudio.com/)
2. Instalar extension de OmniSharp
3. Clonar repositorio `git clone git@github.com:johnnietirado/code-challenges-parkner.git`
4. Abrir proyecto en VSCode
5. OmniSharp te dira que el proyecto no esta formateado correctamente, deja que OmniSharp lo arregle.
6. Aprieta `ctrl + f5` para correr el API.

[Aqui estan las instruciones de Microsoft para instalar y correr un web api](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-2.2&tabs=visual-studio-code)

---
Links de ayuda

[Como crear una API Net Core usando MongoDB](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-2.2&tabs=visual-studio-code)

[MongoDB C# Drive](http://mongodb.github.io/mongo-csharp-driver/2.8/getting_started/)
