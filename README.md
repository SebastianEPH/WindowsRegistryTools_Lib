# Librería -Regedit de Windows v1.0
<!-- Botones -->

<!-- Descripción -->
## Descripción
Ésta librería está pensaba para crear, leer y eliminar llaves, sin escribir tanto codigo, o tener que saber muchos sobre los registros de Windows


<!-- Herramientas -->
# Registros:
 **Cuenta con un apartado completo para la siguientes herramientas.**
![FWO-Regedit](https://i.imgur.com/VxvRqCN.png)
- Lee Registros
    - Ingresa la ruta de la llave, y poderá obtener el valor dentro de ella
- Crea Contenedor de Registros
    - Ingrese la ruta donde desea crear el contenedor e ingrese el nombre
- Crea Llave de Registros
    - Ingrese la ruta del contenedor donde desea crear la llave de registro
    - **El valor de la llave puede tener distintos formatos**
```md
            *String Value*
            *Binarie Value*
            *DWORD (32bits) Value*
            *QWORD (64bits) Value*
            *Multi-String Value*
            *Expandable String* 
```    
- Elimina Registros
    - Puede eliminar un contenedor con todas la llaves adentro
    - Puede eliminar solo una llave especifica

En el apartado de Backup, se buscará realizar una copia de seguridad de los registros importantes del sistema, como por ejemplo:
- Programas que se inician automaticamente al encender la PC
- Información de Extensión de Archivos
    - Programas predeterminados al abrir x archivo
- clic derecho del Mouse
    -Información 
 
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
### **NOTA:** Es importante detallar que todas éstas funciones devolverán un mensaje de `"Exito"` o `"Error"`, según sea el caso,
### Cuando la función sea llamada, deberá almacenarse en una variable tipo `string ` o `String`
---
<!-- Funciones e información de usos -->
## Función - Crear Contenedor
No hay misterio, solo tenemos que colocar la ruta y el nombre que deseamos que tenga nuestra carpeta contenedora
````csharp
    // La documentación está en proceso de escritura, en estos días se terminará por completo, porfavor espere...
````
---
## Función - Crear llave
Las llaves de registro, aceptas distintos tipos de datos, como lo son:
- String Value
- Binarie Value
- DWORD (32bits) Value
- QWORD (64bits) Value
- Multi-String Value
- Expandable String

Entonces veremos cómo podemos crear llaves con todos estos distintos tipos de datos

#### String Value:
![02 -](https://i.imgur.com/rGUjWwS.png)
````c
// key_ruta     = Ruta de Regedit de Windows
string key_ruta = @"HKEY_CURRENT_USER\Software\Adobe\Photoshop";

// key_name     = Es el nombre que tendrá llave
string key_name = "Soy una llave";

// key_values   = Son los valores que almacenará la llave - String
string key_values = "Soy un valor String";

//message       = Se mostrará un mensaje de exito, si se ejecutocorrectamente o uno de error, si hubo algún inconveniente
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
    // La documentación está en proceso de escritura, en estos días se terminará por completo, porfavor espere...
````
#### DWORD (32bits) Value:

````csharp
    // La documentación está en proceso de escritura, en estos días se terminará por completo, porfavor espere...
````
#### QWORD (64bits) Value:

````csharp
    // La documentación está en proceso de escritura, en estos días se terminará por completo, porfavor espere...
````
#### Multi-String Value:

````csharp
    // La documentación está en proceso de escritura, en estos días se terminará por completo, porfavor espere...
````
#### Expandable String:

````csharp
    // La documentación está en proceso de escritura, en estos días se terminará por completo, porfavor espere...
````

## Función - Leer llaves
````csharp
    // La documentación está en proceso de escritura, en estos días se terminará por completo, porfavor espere...
````
## Función - Eliminar contenedores
````csharp
    // La documentación está en proceso de escritura, en estos días se terminará por completo, porfavor espere...
````

## Función - Eliminar llaves
````csharp
    // La documentación está en proceso de escritura, en estos días se terminará por completo, porfavor espere...
````



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
---
