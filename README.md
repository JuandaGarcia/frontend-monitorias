# Frontend Monitorias
![monitorias](https://firebasestorage.googleapis.com/v0/b/files-f91c4.appspot.com/o/Mockup.jpg?alt=media&token=2936fd83-6d26-4494-aaa3-a5579132b61d)

## Descripción del proyecto
Este proyecto sirve para llevar un control de las monitorias de la Universidad Santiago de Cali. La plataforma cuenta con tres roles de usuario (administrador, usuario normal, monitor) donde el usuario administrado puede crear monitorias, editarlas o eliminarlas, también puede crear convertir usuarios en monitores y asignarles monitorias creadas. El usuario normal puede ver las monitorias que están disponibles y apuntarse a ellas, también pueden ver un horario donde aparecen las monitorias a las cuales se han apuntado. Este es realizado con Blazor de dotnet y se conecta a una API hecha con web-api de dotnet. Repositorio de la API: https://github.com/Catmendoza/monitorias-backend

## Integrantes
- Catalina Mendoza
- Juan Jose Castro
- Juan David García Rincón

## Explicación Técnica
Esta aplicación de monitorias en la parte del back end se desarrolló una WebApi con MongoDB y se tiene unos modelos con unos atributos requeridos para guardar y validar la información en la base de datos. También se desarrolló controladores para configurar las peticiones http (get, post, put, delete) que se solicitan desde el front end. Y se creó unos servicios para conectarse con la base de datos. 
En el front end de esta aplicación se utilizó Blazor para desarrollar una SPA “single-page-application” y basar la aplicación en componentes para tener un mejor rendimiento. También se utilizó la librería System.Net.Http.Json en la versión 3.2.1 para realizar las consultas http de la API desde el front end.

![monitorias](https://firebasestorage.googleapis.com/v0/b/files-f91c4.appspot.com/o/Frame%206.png?alt=media&token=fe82f14a-75a3-4ad5-ab12-e08a9907342c)

## Pasos para correr el proyecto:
1. Clonar el repositorio del proyecto ```git clone https://github.com/JuandaGarcia/frontend-monitorias.git```
2. Tener instalado dotnet. https://dotnet.microsoft.com/download
3. Ejecutar el comando ```dotnet run``` en la carpeta donde tengas el proyecto.
4. ¡Listo! Ya puedes abrir el proyecto en el navegar con la URL: http://localhost:5000
