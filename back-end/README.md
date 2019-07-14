# Parkner Back End Challenge

Este reto tiene 3 partes y una opcional:

1. [Completar varios End-points que no estan programados](#parte-uno)
  - Este paso te ayudara a familiarizarte con el código y como funciona el API.
  - Las soluciones deberian de tomar entre 3-5 lines de código.
  - Estos tendran dentro de su cuerpo una excepción de tipo `NotImplementedException` y contienen las instrucciones.
  
2. [Crear un nuevo end-point para obtener informacion de sesiones](#parte-dos).
  - Aquí debes crear un nuevo end-point siguiendo el estilo de la API (Crear un Repository, Service y Controller).
  - Esta parte deberia de tomarte 30-45 minutos
  
3. [Usar MongoDB driver y Aggregations](#parte-tres)
  - Esta parte pondra en prueba tus habilidades de manipulación de data y queries de MongoDB.
  - Se busca un conocimiento de filtros de MongoDB y funciones del aggregation pipeline.
  
4. [**OPCIONAL** - Diviertete con la API de Star Wars](#parte-cuatro)
  - Esta parte es opcional y **no contara en contra si no se hace.**
  - Queremos ver si puedes obtener información de una API, manipularla y presentarla al usurio final. 
  
## Parte Uno 📚

Bienvenido a la primera parte, la meta es familiarizarte con el código. Este proyecto tiene un formato muy similar al API en producción de Parkner.

Un resumen breve en como esta dividida el API.
  - **Controllers**: Punto de acceso a la API (End-points)
  - **Services**: Modulos donde se manipula la información de un *Modelo* con conexión a un Repository.
  - **Repository**: Conexión directa a la base de datos. Aquí es donde se hace cualquier operación con la base de datos.
  - **Models**: Las clases que representan los diferentes objetos en la applicación y que estan asociados con cada documento en la base de datos.
  
El flujo de información es el siguente:

El cliente llama al API que usa la URL para llamar un **Controller** que luego llama un **Service**. El service puede obtener información de un **Repository** y regresar información al **Controller**.

Un ejemplo puede verse en el *GET* Method en `UserController.cs`

Hay 3 metodos que deben ser completados en esta etapa:

1. `GetUser` en `UserService.cs`
2. `GetLot` en `LotController.cs`
2. `GetLot` en `LotRepository.cs`

Si has implementado correctamente los metodos las siguientes URL te regresaran valores en formato JSON

1. [https://localhost:5001/api/users/5d2a65851c9d440000bbf57b](https://localhost:5001/api/users/5d2a65851c9d440000bbf57b)
2. [https://localhost:5001/api/lots](https://localhost:5001/api/lots)
3. [https://localhost:5001/api/lots/5d2a78e17601b1c2f672d2a6](https://localhost:5001/api/lots/5d2a78e17601b1c2f672d2a6)

¡Con esto terminas la parte uno 🤓!

## Parte Dos 💻

Ahora crearas tu propio **Controller**, **Service** y **Repository**.

Crea un Controller que tenga los siguientes metodos:

1. `Get`
2. `GetSession`
3. `GetRevenueByMonth` (Se usara en la parte tres)
  - ruta: `report`
4. `GetSessionReportForLot` (Se usara en la parte tres)
  - ruta: `report/{lotId}`

Deberia de ser bastante obvio basado en la parte uno que el `Get` method obtiene todas las sesiones y el `GetSession` solo obtien UNA sesión.

**IMPORTANTE**

El nombre del COLLECTION es **sessions**

Una vez que hayas implementado lo de arriba deberian de funcionar los siguientes URL:

1. [https://localhost:5001/api/sessions](https://localhost:5001/api/sessions/5d2a65851c9d440000bbf57b)
2. [https://localhost:5001/api/sessions/5d2a65851c9d440000bbf57b](https://localhost:5001/api/sessions/5d2a65851c9d440000bbf57b)

Si pudiste visualizar las sesiones has completado la segunda parte. 🙌🏼

## Parte Tres 📐

La última parte del reto va a poner a prueba tus habilidades de MongoDB.

1 - Primero filtremos las sesiones. 

Deberiamos poder pasar query parameters a `/sessions` para obtener sesiones que estan activas. Al pasar el query paramater `active=true` deberia de regresar 3 sesiones. **Una sesión esta activa cuando no tiene una fecha final**.



## Parte Cuatro - OPCIONAL

---
Links de ayuda

[Como crear una API Net Core usando MongoDB](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-2.2&tabs=visual-studio-code)
