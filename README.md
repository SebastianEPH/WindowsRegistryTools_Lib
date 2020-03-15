# Librería -Regedit de Windows v3.0
<!-- Botones -->
Nueva documentación  v3.0    "Beta"
<!-- Descripción -->
## Descripción
Ésta librería sirve para poder crear , leer y eliminar llaves de registro de Windows, de una manera sencilla en C#.
Ver todas sus funcionalidades [aquí.](https://github.com/SebastianEPH/WindowsRegistryTools_Libreria#uso-de-funciones)

<!-- Información de codificación -->
# ¿Cómo agrego ésta librería a mi proyecto?
1. Coloque el archivo *Regedit.cs* dentro de su proyecto. 

    ![01 - Explorador de Soluciones - C# ](https://i.imgur.com/8tqiZYc.png)

2. Importamos la carpeta donde se encuentra el archivo *Regedit.cs*
    ````csharphttps://www.youtube.com/watch?v=axYhF2LgKEs
    using RegistryTools.Libs;
    ````
3. Instanciamos la librería dentro de la clase, para así poder usarlo.
    - *El nombre que se le dará a ésta instancia será* **registro**.  
(Usted puede colocarle el nombre que desee)
    ```` csharp
    Regedit registro = new Regedit();
    ````
**NOTA:** Cada vez que desee usar las funciones de la librería, deberá llamarlo con el nombre *registro* o el nombre que ustedes escogieron.
# Uso de Funciones
**NOTA:** Es importante detallar que todas éstas funciones devolverán un mensaje de `"Exito"` o `"Error"`, según sea el caso. Cuando la función sea llamada, deberá almacenarse en una variable tipo `string ` o `String`.

<!-- Funciones e información de usos -->
## Función - Crear Contenedor
No hay misterio, solo tenemos que colocar la ruta y el nombre que deseamos que tenga nuestra carpeta contenedora
````csharp
// path     = Ruta de Regedit de Windows
string path = @"HKEY_CURRENT_USER\Software\Adobe\Photoshop";

// key_Conteiner     = Es el nombre que tendrá la carpeta contenedora
string key_Conteiner = "Soy un contenedor";

//message       = Se mostrará un mensaje de exito si se ejecutocorrectamente o uno de error si hubo algún inconveniente
string message = "";

//Ejecutando
message = registro.createConteiner(path, key_Conteiner);

// Muestra en consola mensaje de error o exito
Console.WriteLine(message);
````
---
## Función - Crear llave
Las llaves de registro, aceptan distintos tipos de datos, como lo son:
- String Value
- Binarie Value
- DWORD (32bits) Value
- QWORD (64bits) Value
- Multi-String Value
- Expandable String

Entonces veremos cómo podemos crear llaves con todos estos distintos tipos de datos

#### String Value:
![02 -](https://i.imgur.com/rGUjWwS.png)
````csharp
// path     = Ruta de Regedit de Windows
string path = @"HKEY_CURRENT_USER\Software\Adobe\Photoshop";

// nameValue     = Es el nombre que tendrá llave
string nameValue = "Soy una llave";

// data   = Son los valores que almacenará la llave - String
string data = "Soy un valor String";

//message       = Se mostrará un mensaje de exito si se ejecuto correctamente o uno de error si hubo algún inconveniente
string message = "";

//Ejecutando
message = registro.createKeyValue_String(path, nameValue, data);

// Muestra en consola mensaje de error o exito
Console.WriteLine(message);
````
- Antes de la ejecución

![03](https://i.imgur.com/OOknWxs.png)

- Luego de la ejecución

![04](https://i.imgur.com/4mS08zL.png)

#### Binarie Value:

````csharp
    //Ésta funcionalidad se está trabajando, porfavor espere...
````
#### DWORD (32bits) Value:

````csharp
    //Ésta funcionalidad se está trabajando, porfavor espere...
````
#### QWORD (64bits) Value:

````csharp
    //Ésta funcionalidad se está trabajando, porfavor espere...
````
#### Multi-String Value:

````csharp
    //Ésta funcionalidad se está trabajando, porfavor espere...
````
#### Expandable String:

````csharp
    //Ésta funcionalidad se está trabajando, porfavor espere...
````
---
## Función - Leer llaves
**NOTA:** 13/03/20 Hay un problema al leer valores tipos (MultiString), se pretende resolver éste problema en las proximas actualizaciones
````csharp
// path     = Ruta de Regedit de Windows
string path = @"HKEY_CURRENT_USER\Software\Adobe\Photoshop";

// nameValue     = Es el nombre que tendrá llave
string nameValue = "licencia";

//message       = Se mostrará un mensaje de exito si se ejecuto correctamente o uno de error si hubo algún inconveniente
string message = "";

//Ejecutando
message = registro.readKeyValue(path,nameValue);

// Devolverá el valor de la llave nameValue, en un String
Console.WriteLine(message);
````
## Función - Eliminar contenedor
NOTA: Al Eliminar un contendor, ésta borarrá todas las llaves que pueda almacenar.
````csharp
// path     = Ruta de Regedit de Windows
string path = @"HKEY_CURRENT_USER\Software\Adobe\Photoshop";
//message       = Se mostrará un mensaje de exito si se ejecuto correctamente o uno de error si hubo algún inconveniente
string message = "";

//Ejecutando
message = registro.deleteConteinerAll(path);

// Muestra en consola mensaje de error o exito
Console.WriteLine(message);
````

## Función - Eliminar una llave
````csharp
// path     = Ruta de Regedit de Windows
string path = @"HKEY_CURRENT_USER\Software\Adobe\Photoshop";

// nameValue     = El nombre de la llave la cual queremos eliminar
string nameValue = "config";

//message       = Se mostrará un mensaje de exito si se ejecuto correctamente o uno de error si hubo algún inconveniente
string message = "";

//Ejecutando
message = registro.deleteKeyValue(path, nameValue);

// Muestra en consola mensaje de error o exito
Console.WriteLine(message);
````
---
# Software Funcional de la librería
Éste pequeño formulario fue creado, solo con el fin de mostrar cada una de las funcionalidades de ésta librería.
### Crear Contenedor:
![función - Crear Conteiner](https://i.imgur.com/tIypAQf.png)

Podemos observar que se creó *Conteiner* dentro de la *Software*
![función - crear conteiner - regedit ](https://i.imgur.com/IO0ZMYt.png)
### Crear Llave:
![función - Llave](https://i.imgur.com/qp6BicO.png)
### Leer llave:
![función - Leer Llave](https://i.imgur.com/9TfWNW2.png)
### Eliminar llave:
![función - Eliminar Llave](https://i.imgur.com/aASUe3w.png)
### Eliminar contenedor:
![función - Eliminar Conteiner](https://i.imgur.com/se2U0GF.png)
---
# Código de errores y advertencias: 
- E#R001 = La Ruta ingresada está vacía.
- E#R002 = La Ruta ingresada no es valida.
- E#R003 = La Nombre del valor está vacía
- E#RR01 = Hubo un error al Leer el Valor
- E#RR02 = No se encontró ningún valór con ese nombre
- E#RR03 = El nombre del valor ingresado está vacío

- E#XITO = La Función se ejecuto correctamente; 
---
# Usos en Softwares
Ésta librería es utilizada en el Software [FullWindowsOptimitation](https://github.com/SebastianEPH/FullWindowsOptimitation_FWO_C-Charp)

---
# Código Fuente
Éste proyecto se creó con el IDE Visual Studio 2019 [Puedes obtener la version comunidad gratis aquí](https://www.visualstudio.com/vs/community/).
Verificar las siguientes herramientas estén descargadas e instaladas correctamente:

- Desktop development with C#
- .NET desktop development

You also need to install the following individual components:

- Any of the VC++ 2017 toolsets (latest prefered)
- Windows 10 SDK (10.0.17134.0)
- .NET Framework 4.7 SDK
- .NET Framework 4.7 targeting pack

---
<!-- Licencia -->
## Licencia
--- 
<!-- Creador  -->
---
## By SebastianEPH
- [Github](https://github.com/SebastianEPH)
- [Facebook](https://www.facebook.com/SebastianEPH)
- [Linkedin](https://www.linkedin.com/in/sebastianeph/)
---
