# Librería -Regedit de Windows v3.1
<!-- Botones -->
- **NOTA:** Librería v3.1 Terminada a un `100%`
- Documentación actualizada el día: `24/03/2020`

**Usted encontrará dos carpetas llamadas:** Estos 2 proyectos , son solo para probar el uso de las funciones de la librería.
* `WindowsRegistryTools - Versión Consola` *terminado 100%*: Prueba de todas la funcionalidades mediante Consola
* `WindowsRegistryTools - Versión formulario` *Terminado 90%*: Prueba de todas las funcionalidades utilizando un Formulario **Está en un 90% - está en proceso de desarrollo**
<!-- Descripción -->
## Descripción
Esta librería fue desarrollada para Crear, Leer y eliminar llaves del registro de Windows (*REGEDIT*) y poder realizarlo de la manera más sencilla posible.

### Funcionalidades
Éstas son las funcionalidades de ésta librería en su versión 3.1v, Usted pueder ver [aquí](https://github.com/SebastianEPH/WindowsRegistryTools_Libreria#c%C3%B3mo-agrego-%C3%A9sta-librer%C3%ADa-a-mi-proyecto), *¿Cómo agregar ésta librería a mi proyecto?*
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
1. Dentro de tu __proyecto__, cree una carpeta llamada `Libs` *"Opcional"*

    ![01 - Explorador de Soluciones - C# ](https://i.imgur.com/Rx3MY3k.png)

2. => En la Carpeta **Libs** =>**Clic derecho** => **Agregar** => **Elemento Existente** 

    ![02 - Importamos la librería](https://i.imgur.com/brYmXmZ.png)

3. Buscamos la __Librería__ y agregamos. 

    ![03 - Seleccionamos la librería](https://i.imgur.com/CTd0mBG.png)

4. Listo, ya está importada la __librería__

    ![04 - Final](https://i.imgur.com/vYlvPo0.png)


5. Instanciamos la __Librería__ dentro de __Clase__, para así poder usarlo.
    
    _*El nombre que se le dará a ésta instancia será* **registro**._
    _(Usted puede colocarle el nombre que desee)_
    ```` csharp
    RegistryTools registro = new RegistryTools();
    ````
    **NOTA:** Usted tendrá que escribir el nombre _"registro"_, vada vez va a usar las funcionalidades de la librería.

---
# Uso de Funciones
Lea detalladamente éste apartado, donde se podrán despejar algunas dudas.
- __Camino del registro (path):__ Variable`path`, Se almacena el camino de la ruta, la librería acepta distintos tipos de sintaxis, las cuales son las siguientes:

    * ``"Computer\"``.................Ejemplo: `Computer\HKEY_CURRENT_USER\Control Panel\Appearance`
    * `"Equipo\"`.....................Ejemplo: `Equipo\HKEY_CURRENT_USER\Control Panel\Appearance`
    * `""`.....................................Ejemplo: `HKEY_CURRENT_USER\Control Panel\Appearance`
- __Nombre de la llave (keyName):__ Variable `keyName`, se almacenará el nombre de la llave de registro.
    * Ejemplo: `AppEvents`, `Console`, `Control Panel`, `Environment`, `EUDC`, `Keyboard Layout`, `Network`, `Printers`, `Software`, `System`, `Voltatile Environment` 

        ![KeyName - Llaves de registro](https://i.imgur.com/QtIaMI0.png)

- __Nombre del Valor (valueName):__ Variable `valueName`, se almacenará el nombre que tendrá el Valor dentro de una llave.
    * Ejemplo: `Soy un valor tipo`

        ![ValueName - Regedit](https://i.imgur.com/jozcZyo.png)

- __Datos del Valor (valueData):__ Variable `valueName`, se almacenará los datos dentro de un valor, éstos datos pueden variar según sea el _Tipo de Dato_.

    * Ejemplo: `Cadena de Texto corta`, `01 D4 F1 08`, `5415615545`, `9498489498898`, `linea1\nlinea2\nlinea3`, `cadena de Texto larga`

        ![Tipo ](https://i.imgur.com/MLFyCkv.png)

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
- Binarie Value.................................................`(Tipo de Valor: byte[] - Decimal)`
- DWORD (32bits) Value.............................`(Tipo de Valor: Int32 - Decimal)`
- QWORD (64bits) Value.............................`(Tipo de Valor: Int64 - Decimal)`
- Multi-String Value......................................`(Tipo de Valor: String [])`
- Expandable String......................................`(Tipo de Valor: String)`

#### Crear - String Value:

````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeString";

// Son los valores que se almacenarán en la llave
string valueData = "Soy un dato tipoString";

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_String(path, keyName, valueData));
````


#### Crear - Binary Value:
Los valores que usted ingresará deben ser decimales tipo *bytes*, separando individualmente los datos mediante una ','
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypypeBinary"; 	

// Son los valores que se almacenarán en la llave
byte [] valueData = {1,5,7,8,9,5,40,56,12,89,1,5,14,5,5,1,154,24};  

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_Binarie(path, keyName, valueData));   
````
#### Crear - DWORD (32bits) Value:
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeInt32"; 	

// Son los valores que se almacenarán en la llave
Int32 valueData = "123456789"; // Valor máximo -2147483648 a 2147483647 

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_DWORD(path, keyName, valueData));
````
#### Crear - QWORD (64bits) Value:

````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeInt64"; 	

// Son los valores que se almacenarán en la llave
Int64 valueData = "123456789"; // Valor máximo -9223372036854775808 a 9223372036854775807 

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_QWORD(path, keyName, valueData));
````
#### Crear - Multi-String Value:

````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeInt64"; 	

// Son los valores que se almacenarán en la llave
string [] valueData = {"txt1","txt2","txt3","texto"}; // texto con saltos de linea
                                                      // No tiene limite de saltos de linea 

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_MultiString(path, keyName, valueData));
````
#### Crear - Expandable String:

````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "New Value TypeExpandString";

// Son los valores que se almacenarán en la llave
string valueData = "Soy un dato tipo ExpandString";

// Ejecuta y muestra en consola (Exito o algún código de error)
Console.WriteLine(registro.CreateKeyValue_ExpandString(path, keyName, valueData));
````
---
## Función - Obtener o leer Valores
#### Obtiene datos - String
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "value String";

// Ejecuta y guarda los datos dentro de la variable
String valueData = registro.CreateKeyValue_String(path, keyName, valueData));
// En caso de algún error de leer la llave, mandará un código de error 
// Verifica el código de error en la documentación
````
#### Obtiene datos - Binary
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "value Binary";

// Ejecuta y guarda los datos dentro de la variable
byte [] valueData = registro.CreateKeyValue_Binary(path, keyName, valueData));
````
#### Obtiene datos - DWORD
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "value DWORD";

// Ejecuta y guarda los datos dentro de la variable
Int32 valueData = registro.CreateKeyValue_DWORD(path, keyName, valueData));
// En caso de algún error de leer la llave, mandará un código de error 
// Verifica el código de error en la documentación
````
#### Obtiene datos - QWORD
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "value QWORD";

// Ejecuta y guarda los datos dentro de la variable
Int64 valueData = registro.CreateKeyValue_QWORD(path, keyName, valueData));
// En caso de algún error de leer la llave, mandará un código de error 
// Verifica el código de error en la documentación
````
#### Obtiene datos - MultiString
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "value MultiString";

// Ejecuta y guarda los datos dentro de la variable
String [] valueData = registro.CreateKeyValue_MultiString(path, keyName, valueData));
// En caso de algún error de leer la llave, mandará un código de error 
// Verifica el código de error en la documentación
````
#### Obtiene datos - ExpandString
````csharp
// Camino de ruta de la llave
string path = @"HKEY_CURRENT_USER\Software\NombreDeLlave";

// Es el nombre del Valor 
string valueName = "value ExpandString";

// Ejecuta y guarda los datos dentro de la variable
String valueData = registro.CreateKeyValue_ExpandString(path, keyName, valueData));
// En caso de algún error de leer la llave, mandará un código de error 
// Verifica el código de error en la documentación
````
## Función - Eliminar Llave
__NOTA:__ Al Eliminar la llave, ésta borrará todos los valores que pueda almacenar.
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
# Software Funcional de la librería - Consola
## Menú principal
Podemos observa el menú con todas las funcionalidades de la librería, solo tenemos que escoger una opción valida, para poder entrar al subMenú.
![Console - Menú principal](https://i.imgur.com/FKQH4Kx.png)


Según sea el caso nos pedirá ingresar el camino de ruta
![Console -Insertar ruta path](https://i.imgur.com/PqKuMCa.png)

Según sea el caso nos pedirá ingresar el Nombre del Valor
![Console -Insertar nombre del Valor](https://i.imgur.com/cFS6CcW.png)

Según sea el caso nos pedirá ingresar los datos del valor, la cual cambiará según la opción escogida en el menú principal
![Console -Insertar nombre del Valor](https://i.imgur.com/E92gF0n.png)

Al culminar el proceso, la Consola mostrará un mensaje de error o de Exito, la lista lo puedes ver [aquí](https://github.com/SebastianEPH/WindowsRegistryTools_Libreria#c%C3%B3digo-de-errores-advertencias-y-exito)
![Console -Mensaje de exito o error](https://i.imgur.com/1GhT9Xt.png)


# Software Funcional de la librería - Formulario
<!--
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
![función - Eliminar Conteiner](https://i.imgur.com/se2U0GF.png) -->

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
