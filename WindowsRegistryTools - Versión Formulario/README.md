# Librería -Regedit de Windows v3.1
<!-- Botones -->
**NOTA:** Librería v3.1 Terminada a un 60%

Documentación actualizada el día: `21/03/2020`
<!-- Descripción -->
## Descripción
Esta librería fue desarrollada para Crear, Leer y eliminar llaves del registro de Windows (*REGEDIT*) y poder realizarlo de la manera más sencilla posible.

### Funcionalidades
Éstas son las funcionalidades de ésta librería en su versión 3.0v, Usted pueder ver [aquí](https://github.com/SebastianEPH/WindowsRegistryTools_Libreria#c%C3%B3mo-agrego-%C3%A9sta-librer%C3%ADa-a-mi-proyecto), *¿Cómo agregar ésta librería a mi proyecto?*
- **Crear llaves:**
    - HKEY_CLASSES_ROOT...............................`(No Requiere permisos de administrador)`
    - HKEY_CURRENT_USER..............................`(No Requiere permisos de administrador)`
    - HKEY_LOCAL_MACHINE...........................`(Requiere permisos de administrador)`
    - HKEY_USERS.................................................`(Requiere permisos de administrador)`
    - HKEY_CURRENT_CONFIG........................`(Requiere permisos de administrador)`
- **Crear Valores de llaves:**
    - String Value...................................................`(Tipo de Valor: String)`
    - Binarie Value.................................................`(Tipo de Valor: Byte[] - Decimal)`
    - DWORD (32bits) Value.............................`(Tipo de Valor: Int32 - Decimal)`
    - QWORD (64bits) Value.............................`(Tipo de Valor: Int64 - Decimal)`
    - Multi-String Value......................................`(Tipo de Valor: String [])`
    - Expandable String......................................`(Tipo de Valor: String)`
- **Obtener ó leer valores de una llave:**
    - String Value..................................................`(Retornará un String)`
    - Binarie Value................................................`(Retornará un Byte [])`
    - DWORD (32bits) Value.............................`(Retornará un Int32)`
    - QWORD (64bits) Value.............................`(Retornará un Int64)`
    - Multi-String Value......................................`(Retornará un String [])`
    - Expandable String......................................`(Retornará un String)`



- **Eliminar Llave**

    _**NOTA:** Esta función eliminar una llave y todos los valores que ésta pueda almacenar_

- **Eliminar Valores**

    _**NOTA:** Ésta funcionalidad solo eliminará un valor, si desea eliminar todos los valores dentro de una llave, usted puede usar la función anterior "**Eliminar Llave**"._
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
    
    _*El nombre que se le dará a ésta instancia será* **registro**._
    _(Usted puede colocarle el nombre que desee)_
    ```` csharp
    Regedit registro = new Regedit();
    ````
    _**NOTA:** Cada vez que desee usar las funciones de la librería, deberá llamarlo con el nombre *registro* o el nombre que ustedes escogieron_

---
# Uso de Funciones
Lea detalladamente éste apartado, donde se podrán despejar algunas dudas.
- __Camino del registro (path):__ En ésta variable `path`, es donde se realizarán las operaciones, ésta librería reconoce los `path` si empiezan con este tipo de sintaxis:

    * ``"Computer\"``.................Ejemplo: `Computer\HKEY_CURRENT_USER\Control Panel\Appearance`
    * `"Equipo\"`......................Ejemplo: `Equipo\HKEY_CURRENT_USER\Control Panel\Appearance`
    * `""`......................................Ejemplo: `HKEY_CURRENT_USER\Control Panel\Appearance`


_**NOTA:** Es importante detallar que todas éstas funciones devolverán un *Código de errores, advertencias y de exito*, La lista completa puedes verla [aquí](https://github.com/SebastianEPH/WindowsRegistryTools_Libreria#c%C3%B3digo-de-errores-advertencias-y-exito)_

<!-- Funciones e información de usos -->
## Función - Crear Llave
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software";

// Es el nombre de la Llave
string keyName = "NombreDeLlave";

// Ejecuta pero no muestra ningún mensaje
registro.CreateKey(path, keyName);

// Ejecuta y muestra en consola (Exito o algún código de error)
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
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeString";

// Son los valores que se almacenarán en la llave
string valueData = "Soy un dato tipoString";

// Ejecuta pero no muestra ningún mensaje
registro.CreateKeyValue_String(path, keyName,valueData);

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_String(path, keyName, valueData));
````
- Antes de la ejecución

![03](https://i.imgur.com/OOknWxs.png)

- Luego de la ejecución

![04](https://i.imgur.com/4mS08zL.png)

#### Binarie Value:
Los valores que usted ingresará deben ser decimales tipo *bytes*, separando individualmente los datos mediante una ','
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypypeBinarie"; 	

// Son los valores que se almacenarán en la llave
byte [] valueData = {1,5,7,8,9,5,40,56,12,89,1,5,14,5,5,1,154,24};  

// Ejecuta pero no muestra ningún mensaje
registro.CreateKeyValue_Binarie(path, keyName,valueData);

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_Binarie(path, keyName, valueData));   
````
#### DWORD (32bits) Value:
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeInt32"; 	

// Son los valores que se almacenarán en la llave
Int32 valueData = "123456789"; // Valor máximo -2147483648 a 2147483647 

// Ejecuta pero no muestra ningún mensaje
registro.CreateKeyValue_DWORD(path, keyName,valueData);

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_DWORD(path, keyName, valueData));
````
#### QWORD (64bits) Value:

````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeInt64"; 	

// Son los valores que se almacenarán en la llave
Int64 valueData = "123456789"; // Valor máximo -9223372036854775808 a 9223372036854775807 

// Ejecuta pero no muestra ningún mensaje
registro.CreateKeyValue_QWORD(path, keyName,valueData);

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_QWORD(path, keyName, valueData));
````
#### Multi-String Value:

````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeInt64"; 	

// Son los valores que se almacenarán en la llave
string [] valueData = {"txt1","txt2","txt3","texto"}; // texto con saltos de linea
                                                      // No tiene limite de saltos de linea 

// Ejecuta pero no muestra ningún mensaje
registro.CreateKeyValue_MultiString(path, keyName,valueData);

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_MultiString(path, keyName, valueData));
````
#### Expandable String:

````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeExpandString";

// Son los valores que se almacenarán en la llave
string valueData = "Soy un dato tipo ExpandString";

// Ejecuta pero no muestra ningún mensaje
registro.CreateKeyValue_ExpandString(path, keyName,valueData);

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_ExpandString(path, keyName, valueData));
````
---
## Función - Obtener o leer Valores
Los datos obtenidos de DWORD y QWORD serán datos decimales
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "Soy un Value";

// Ejecuta pero no muestra ningún mensaje
registro.GetDataValues(path, keyName,valueName);

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.GetDataValues(path, keyName, valueName));
````
## Función - Eliminar Llave
NOTA: Al Eliminar la llave, ésta borarrá todos los valores que pueda almacenar.
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Ejecuta pero no muestra ningún mensaje
registro.DeleteKey(path);

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.DeleteKey(path));
````

## Función - Eliminar un valor
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "Soy un Value";

// Ejecuta pero no muestra ningún mensaje
registro.DeleteValue(path, valueName);

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.DeleteValue(path, valueName));
````
---
# Software Funcional de la librería
Éste pequeño formulario fue creado, solo con el fin de mostrar cada una de las funcionalidades de ésta librería.
### Crear LLave:
![función - Crear Conteiner](https://i.imgur.com/tIypAQf.png)

Podemos observar que se creó la Llave dentro de la *Software*
![función - crear conteiner - regedit ](https://i.imgur.com/IO0ZMYt.png)
### Crear Valores:
![función - Llave](https://i.imgur.com/qp6BicO.png)
### Leer Valores:
![función - Leer Llave](https://i.imgur.com/9TfWNW2.png)
### Eliminar Llave:
![función - Eliminar Llave](https://i.imgur.com/aASUe3w.png)
### Eliminar Valores:
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


- -000001 = La Ruta ingresada está vacía.
- -000002 = 
- -000003 = El nombre del valor está vació


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
Apache
--- 
<!-- Creador  -->
---
## By SebastianEPH
- [Github](https://github.com/SebastianEPH)
- [Facebook](https://www.facebook.com/SebastianEPH)
- [Linkedin](https://www.linkedin.com/in/sebastianeph/)
---
