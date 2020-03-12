# Librería -Regedit de Windows v1.0
<!-- Botones -->

<!-- Descripción -->
## Descripción
Ésta librería está pensaba para crear, leer y eliminar llaves, sin escribir tanto codigo, o tener que saber muchos sobre los registros de Windows

<!-- Información de codificación -->
# ¿Cómo uso la librería?
1. Coloque el archivo *Regedit.cs* dentro de su proyecto. 

    ![01 - Explorador de Soluciones - C# ](https://i.imgur.com/8tqiZYc.png)

2. Importamos la carpeta donde se encuentra el archivo *Regedit.cs*
    ````csharp
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
// key_ruta     = Ruta de Regedit de Windows
string key_ruta = @"HKEY_CURRENT_USER\Software\Adobe\Photoshop";

// key_Conteiner     = Es el nombre que tendrá la carpeta contenedora
string key_Conteiner = "Soy un contenedor";

//message       = Se mostrará un mensaje de exito si se ejecutocorrectamente o uno de error si hubo algún inconveniente
string message = "";

//Ejecutando
message = registro.createConteiner(key_ruta, key_Conteiner);

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
// key_ruta     = Ruta de Regedit de Windows
string key_ruta = @"HKEY_CURRENT_USER\Software\Adobe\Photoshop";

// key_name     = Es el nombre que tendrá llave
string key_name = "Soy una llave";

// key_values   = Son los valores que almacenará la llave - String
string key_values = "Soy un valor String";

//message       = Se mostrará un mensaje de exito si se ejecuto correctamente o uno de error si hubo algún inconveniente
string message = "";

//Ejecutando
message = registro.createKeyValue_String(key_ruta, key_name, key_values);

// Muestra en consola mensaje de error o exito
Console.WriteLine(message);
````
- Antes de la ejecución

![03](https://i.imgur.com/OOknWxs.png)

- Luego de la ejecución

![04](https://i.imgur.com/4mS08zL.png)

---
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

## Función - Leer llaves
### Obtiene Valores tipo: (Binario, DWORD, QWORD).

````csharp
// key_ruta     = Ruta de Regedit de Windows
string key_ruta = @"HKEY_CURRENT_USER\Software\Adobe\Photoshop";

// key_name     = Es el nombre que tendrá llave
string key_name = "activate";

//message       = Se mostrará un mensaje de exito si se ejecuto correctamente o uno de error si hubo algún inconveniente
string message = "";

//Ejecutando
message = registro.readKeyValueInt(key_ruta,key_name);

// Devolverá el valor de la llave key_name, en un String
Console.WriteLine(message);
````
### Obtiene Valores tipo: (String, Multi-String, Expanz-String).

````csharp
    // key_ruta     = Ruta de Regedit de Windows
string key_ruta = @"HKEY_CURRENT_USER\Software\Adobe\Photoshop";

// key_name     = Es el nombre que tendrá llave
string key_name = "licencia";

//message       = Se mostrará un mensaje de exito si se ejecuto correctamente o uno de error si hubo algún inconveniente
string message = "";

//Ejecutando
message = registro.readKeyValueString(key_ruta,key_name);

// Devolverá el valor de la llave key_name, en un String
Console.WriteLine(message);
````
## Función - Eliminar contenedor
NOTA: Al Eliminar un contendor, ésta borarrá todas las llaves que pueda almacenar.
````csharp
// key_ruta     = Ruta de Regedit de Windows
string key_ruta = @"HKEY_CURRENT_USER\Software\Adobe\Photoshop";
//message       = Se mostrará un mensaje de exito si se ejecuto correctamente o uno de error si hubo algún inconveniente
string message = "";

//Ejecutando
message = registro.deleteConteinerAll(key_ruta);

// Muestra en consola mensaje de error o exito
Console.WriteLine(message);
````

## Función - Eliminar una llave
````csharp
// key_ruta     = Ruta de Regedit de Windows
string key_ruta = @"HKEY_CURRENT_USER\Software\Adobe\Photoshop";

// key_name     = El nombre de la llave la cual queremos eliminar
string key_name = "config";

//message       = Se mostrará un mensaje de exito si se ejecuto correctamente o uno de error si hubo algún inconveniente
string message = "";

//Ejecutando
message = registro.deleteKeyValue(key_ruta, key_name);

// Muestra en consola mensaje de error o exito
Console.WriteLine(message);
````
# Software Funcional de la librería
Éste pequeño formulario fue creado, solo con el fin de mostrar cada una de las funcionalidades de ésta librería.
### Crear Contenedor:
![función - Crear Conteiner](https://i.imgur.com/tIypAQf.png)

Podemos observar que se creó *Conteiner* dentro de la *Software*
![función - crear conteiner - regedit ](https://i.imgur.com/IO0ZMYt.png)
### Crear Llave:
![función - Crear Conteiner](https://i.imgur.com/tIypAQf.png)
### Leer llave:
![función - Crear Conteiner](https://i.imgur.com/tIypAQf.png)
### Eliminar llave:
![función - Crear Conteiner](https://i.imgur.com/tIypAQf.png)
### Eliminar contenedor:
![función - Crear Conteiner](https://i.imgur.com/tIypAQf.png)
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


<!-- Licencia -->
## Licencia

<!-- Creador  -->
---
## By SebastianEPH
- [Github](https://github.com/SebastianEPH)
- [Facebook](https://www.facebook.com/SebastianEPH)
- [Linkedin](https://www.linkedin.com/in/sebastianeph/)
---
