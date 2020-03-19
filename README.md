# Librería -Regedit de Windows v3.0
<!-- Botones -->
**NOTA:** Librería Terminada a un 95%  - `18/03/2020`
<!-- Descripción -->
## Descripción
Esta librería fue desarollada para Crear, Leer y eliminar llaves del registro de Windows (*REGEDIT*) y poder realizarlo de la manera más sencilla posible.

### Funcionalidades
Éstas son las funcionalidades de ésta librería en su versión 3.0v, Usted pueder ver [aquí](https://github.com/SebastianEPH/WindowsRegistryTools_Libreria#c%C3%B3mo-agrego-%C3%A9sta-librer%C3%ADa-a-mi-proyecto), *¿Cómo agregar ésta librería a mi proyecto?*
- **Crear llaves:**
    - HKEY_CLASSES_ROOT...............................`(Necesita permisos básicos)`
    - HKEY_CURRENT_USER..............................`(Necesita permisos básicos)`
    - HKEY_LOCAL_MACHINE...........................`(Permiso de administrador)`
    - HKEY_USERS.................................................`(Permiso de administrador)`
    - HKEY_CURRENT_CONFIG........................`(Permiso de administrador)`
- **Crear Valores de llaves:**
    - String Value...................................................`(Tipo de Valor: String)`
    - Binarie Value..................................................**(Ésta funcionalidad está en   proceso - No terminado)**
    - DWORD (32bits) Value.............................`(Tipo de Valor: Int32 - Decimal)`
    - QWORD (64bits) Value.............................`(Tipo de Valor: Int64 - Decimal)`
    - Multi-String Value......................................`(Tipo de Valor: String [])`
    - Expandable String......................................`(Tipo de Valor: String)`
- **Obtener ó leer valores de una llave:**
    - String Value..................................................`(Retornará un String)`
    - Binarie Value............................................... `(Retornará un String)`
    - DWORD (32bits) Value.............................`(Retornará un String)`
    - QWORD (64bits) Value.............................`(Retornará un String)`
    - Multi-String Value......................................`(Retornará un String)`
    - Expandable String......................................`(Retornará un String)`

    _**NOTA:** Todos los valores obtenidos serán retornadas mediante una variable *Tipo String*, ésto sin importar el tipo de variable que almacene el valor. Ésta medidase tomó para hacer más sencilla el uso de la librería._

- **Eliminar Llave**

    _**NOTA:** Al eliminar la llave, se eliminarán todos los valores que pueda contener._

- **Eliminar Valores**

    _**NOTA:** Se podrá eliminar el Valor de la llave uno por uno, si desea eliminar todos los valores dentro de la llave, puede usar la funcionalidad ELIMINAR LLAVE_
---
<!-- Información de codificación -->
# ¿Cómo agrego ésta librería a mi proyecto?
1. Coloque el archivo *Regedit.cs* dentro de su proyecto. `Se recomienda que sea dentro de la carpeta Libs `

    ![01 - Explorador de Soluciones - C# ](https://i.imgur.com/8tqiZYc.png)

2. Importamos la carpeta donde se encuentra el archivo *Regedit.cs*
    ````csharphttps://www.youtube.com/watch?v=axYhF2LgKEs
    using RegistryTools.Libs;
    ````
3. Instanciamos la librería dentro de la clase, para así poder usarlo.
    
    *El nombre que se le dará a ésta instancia será* **registro**.  
(Usted puede colocarle el nombre que desee)
    ```` csharp
    Regedit registro = new Regedit();
    ````
    **NOTA:** Cada vez que desee usar las funciones de la librería, deberá llamarlo con el nombre *registro* o el nombre que ustedes escogieron.

---
# Uso de Funciones
**NOTA:** Es importante detallar que todas éstas funciones devolverán un *Código de errores, advertencias o de exito*, La lista completa puedes verla [aquí](https://github.com/SebastianEPH/WindowsRegistryTools_Libreria#c%C3%B3digo-de-errores-advertencias-y-exito)

<!-- Funciones e información de usos -->
## Función - Crear Llave
````csharp
/* Sintaxis permitida:
 *                      - Computer\HKEY_CLASSES_ROOT
 *                      - HKEY_CLASSES_ROOT
 *                      - Equipo\HKEY_CLASSES_ROOT
 */ 
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software";

// Es el nombre de la Llave
string keyName = "NombreDeLlave";

// Ejecuta pero no muestra ningún mensaje
registro.CreateKey(path, keyName);

// Ejecutando y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKey(path, keyName));
````
---
## Función - Crear Valores 
Los registros de Windows nos permite poder crear Valores con distintos tipos de datos según lo necesitemos. Estos son los tipos de datos que aceptan el registro de Windows (Regedit) 
- String Value...................................................`(Tipo de Valor: String)`
- Binarie Value.................................................**(Ésta funcionalidad está en proceso - No terminado)**
- DWORD (32bits) Value.............................`(Tipo de Valor: Int32 - Decimal)`
- QWORD (64bits) Value.............................`(Tipo de Valor: Int64 - Decimal)`
- Multi-String Value......................................`(Tipo de Valor: String [])`
- Expandable String......................................`(Tipo de Valor: String)`

#### String Value:

````csharp
/* Sintaxis permitida:
 *                      - Computer\HKEY_CLASSES_ROOT
 *                      - HKEY_CLASSES_ROOT
 *                      - Equipo\HKEY_CLASSES_ROOT
 */ 
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeString";

// Son los valores que se almacenarán en la llave
string valueData = "Soy un dato tipoString";

// Ejecuta pero no muestra ningún mensaje
registro.CreateKeyValue_String(path, keyName,valueData);

// Ejecutando y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_String(path, keyName, valueData));
````
- Antes de la ejecución

![03](https://i.imgur.com/OOknWxs.png)

- Luego de la ejecución

![04](https://i.imgur.com/4mS08zL.png)

#### Binarie Value:

````csharp
    // Es la unica funcionalidad la cual me está causando problemas al poder crearla,
    // en unas semanas lo soluionaré
````
#### DWORD (32bits) Value:
````csharp
/* Sintaxis permitida:
 *                      - Computer\HKEY_CLASSES_ROOT
 *                      - HKEY_CLASSES_ROOT
 *                      - Equipo\HKEY_CLASSES_ROOT
 */ 
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeInt32"; 	

// Son los valores que se almacenarán en la llave
Int32 valueData = "123456789"; // Valor máximo -2147483648 a 2147483647 

// Ejecuta pero no muestra ningún mensaje
registro.CreateKeyValue_DWORD(path, keyName,valueData);

// Ejecutando y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_DWORD(path, keyName, valueData));
````
#### QWORD (64bits) Value:

````csharp
/* Sintaxis permitida:
 *                      - Computer\HKEY_CLASSES_ROOT
 *                      - HKEY_CLASSES_ROOT
 *                      - Equipo\HKEY_CLASSES_ROOT
 */ 
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeInt64"; 	

// Son los valores que se almacenarán en la llave
Int64 valueData = "123456789"; // Valor máximo -9223372036854775808 a 9223372036854775807 

// Ejecuta pero no muestra ningún mensaje
registro.CreateKeyValue_QWORD(path, keyName,valueData);

// Ejecutando y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_QWORD(path, keyName, valueData));
````
#### Multi-String Value:

````csharp
/* Sintaxis permitida:
 *                      - Computer\HKEY_CLASSES_ROOT
 *                      - HKEY_CLASSES_ROOT
 *                      - Equipo\HKEY_CLASSES_ROOT
 */ 
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeInt64"; 	

// Son los valores que se almacenarán en la llave
string [] valueData = {"txt1","txt2","txt3","texto"}; // texto con saltos de linea
                                                      // No tiene limite de saltos de linea 

// Ejecuta pero no muestra ningún mensaje
registro.CreateKeyValue_MultiString(path, keyName,valueData);

// Ejecutando y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_MultiString(path, keyName, valueData));
````
#### Expandable String:

````csharp
/* Sintaxis permitida:
 *                      - Computer\HKEY_CLASSES_ROOT
 *                      - HKEY_CLASSES_ROOT
 *                      - Equipo\HKEY_CLASSES_ROOT
 */ 
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeExpandString";

// Son los valores que se almacenarán en la llave
string valueData = "Soy un dato tipo ExpandString";

// Ejecuta pero no muestra ningún mensaje
registro.CreateKeyValue_ExpandString(path, keyName,valueData);

// Ejecutando y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_ExpandString(path, keyName, valueData));
````
---
## Función - Obtener o leer Valores
````csharp
/* Sintaxis permitida:
 *                      - Computer\HKEY_CLASSES_ROOT
 *                      - HKEY_CLASSES_ROOT
 *                      - Equipo\HKEY_CLASSES_ROOT
 */ 
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeExpandString";

// Ejecuta pero no muestra ningún mensaje
registro.GetValues(path, keyName,valueName);

// Ejecutando y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.GetValues(path, keyName, valueName));
````
## Función - Eliminar Llave
NOTA: Al Eliminar la llave, ésta borarrá todos los valores que pueda almacenar.
````csharp

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
# Código de errores, advertencias y exito: 
- E#R001 = La Ruta ingresada está vacía.
- E#R002 = La Ruta ingresada no es valida.
- E#R003 = La Nombre del valor está vacía
- E#R004 = La llave tiene un nombre no valido 
- E#R005 = El nombre de la llave está vacía

- E#RR01 = Hubo un error al Leer el Valor
- E#RR02 = No se encontró ningún valór con ese nombre
- E#RR03 = El nombre del valor ingresado está vacío
- E#RR04 = No se puedo crear una el valor de la llave
- E#NN01 = No se encontó una llave con ese nombre ó (No se puedo eliminar por cuestiones de permisos)

- E#CR01 = No se puedo crear la llave (contenedora)
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
jh

--- 
<!-- Creador  -->
---
## By SebastianEPH
- [Github](https://github.com/SebastianEPH)
- [Facebook](https://www.facebook.com/SebastianEPH)
- [Linkedin](https://www.linkedin.com/in/sebastianeph/)
---
