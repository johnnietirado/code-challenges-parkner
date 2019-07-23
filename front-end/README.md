# Desafío Front End

Para este desafío estarás usando [NextJS](https://nextjs.org/docs). Ya se ha creado un proyecto para ti con los paquetes básicos que vas a necesitar.

Tu desafío es obtener una lista de Pendientes de un API y mostrarlos organizadamente en una página web.

### Para correr el código:

``` bash
> yarn install
> yarn run dev
```

Abrir [http://localhost:3000](http://localhost:3000)

### Parte Uno 📓

Como puedes notar nuestra lista de Pendientes no tiene nada 😔

Usa `axios` dentro del archivo `api.ts` para obtener todos los Pendientes de la url y mostrarlos dentro de `index.tsx`

**La página deberia de cargar con todos los Pendientes ya renderizados. Es decir que deben de ser obtenidos desde el servidor usando SSR.**

Una vez que hayas obtenido todos los Pendientes debería de solo mostrar 10 a la vez y poner una manera de navegar 10 a la vez.

### Parte Dos 🔎

Al tener tantos pendientes es complicado buscar uno en específico sin tener una barra de búsqueda.

Agregar una barra de búsqueda a nuestra lista de Pendientes. **Para esto no deberías de estar conectandote a la API, haz la filtración / búsqueda localmente.**

### Parte Tres ✔️

Ahora que podemos buscar los pendientes debería de poder decir si lo completado o no. **Al apretar un Pendiente debería de cambiar su estado de completado.**

Pero ahora que tengo completados mezclados con pendientes deberia de poder filtrar por ellos. **Agrega esta función a la página web.** Debería de haber una manera fácil de saber cuál ha sido completado y cual no.

### Parte Cuatro 📝

Finalmente, deberia de poder agregar un nuevo Pendiente a la página. No se tiene que hacer ninguna llamada a la API para guardar el nuevo pendiente, pero si se debería de visualizar en la lista como el primero.

### Conclusión

Al finalizar el proyecto pon todos tus archivos excluyendo `/node_modules` y `.next` en un `.zip` y enviar a [johnnie@parkner.pe](mailto:johnnie@parkner.pe)

También incluye tu CV