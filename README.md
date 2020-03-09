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

## Crear llave y contenedor
## Leer llaves
## Eliminar llaves y contenedores

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
### By SebastianEPH
---
