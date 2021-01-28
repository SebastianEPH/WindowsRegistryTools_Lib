using System;
using Microsoft.Win32;  //Librería importante 

public class RegistryWin {

    public string PATH = "";    // PATH Limpio 
    private int TYPE = -1;
    public string TYPE_REGISTRY = "";
    public bool HAS_PARAMETER = false; // Tiene parametros
    public string PARAMETER = "";
    private RegistryKey k;

    private string[] TYPE_REGISTRY_ARR = {"HKEY_CLASSES_ROOT",
                                    "HKEY_CURRENT_USER",
                                    "HKEY_LOCAL_MACHINE",
                                    "HKEY_USERS",
                                    "HKEY_CURRENT_CONFIG"};

    public RegistryWin(string path) {
        this.PATH = path;
        Check_path();   // Verifica si la ruta es correcta o manda una excepción 
        Clear_path();   // limpia ruta
        Get_type_path();// Obtiene el tipo de registro
        Parameter();     // Obtiene Parametros
        OpenKey();      
                         // Si existe parametros, obtiene el nombre del ultimo key
                         // path sin subpath y sin key




    }

    public void CreateKey() {

    }
    public void DeleteKey() {
        if (!HAS_PARAMETER) { 
            // mandar excepcion, por que no puedes eliminar con una ruta sin key 
        }
    }
    public void ReadValue() {

    }
    private void OpenKey(bool delete = false) {
        string path = "";
        if (delete) {
            path = this.PARAMETER; // Param sin key 
        } else {
            path = this.PARAMETER;
        }
        switch (TYPE) {
            case 0: k = Registry.ClassesRoot.OpenSubKey(path,true); break;
            case 1: k = Registry.CurrentUser.OpenSubKey(path,true); break;
            case 2: k = Registry.LocalMachine.OpenSubKey(path,true); break;
            case 3: k = Registry.Users.OpenSubKey(path,true); break;
            case 4: k = Registry.CurrentConfig.OpenSubKey(path,true); break;
            default:
                break;
        }

    }
    private void CheckValue(string valueName) {
        if (valueName.Equals("")) {
            throw new EmptyValueName();
        }
    }

    public void SetValue_String(string valueName, string valueData = "") {
        CheckValue(valueName);
        try {
            k.SetValue(valueName,valueData,RegistryValueKind.String);
        } catch {
            throw new StringSintax();
        }
        
    }
    public void SetValue_Binary(string valueName, byte[] valueData) {
        CheckValue(valueName);
        try {
            k.SetValue(valueName,valueData,RegistryValueKind.Binary);
        } catch {
            throw new StringSintax();
        }
    }
    public void SetValue_DWORD() {

    }
    public void SetValue_QWORD() {

    }
    public void SetValue_MultiString() {

    }
    public void SetValue_ExpandableString() {

    }
    public void DeleteValue() {

    }
    private void Check_path() {  // Verifica si la ruta es correcta
        bool pass = false;
        if (this.PATH.Equals("")) {
            throw new EmptyPath();
        }
        for (int i = 0; i < this.TYPE_REGISTRY_ARR.Length; i++) {
            int ixt = this.PATH.IndexOf(this.TYPE_REGISTRY_ARR[i]);
            if (ixt != -1) {
                Console.WriteLine(ixt + " $$ " + this.TYPE_REGISTRY_ARR[i]);
                pass = true;
            } 
        }
        if (!pass) {
            throw new InvalidPath(this.PATH);
        }
    }
    private void Clear_path() { // Elimina el subpath de la ruta ingresada por el usuario
        int ixt = this.PATH.IndexOf(@"HKEY_");
        this.PATH = this.PATH.Substring(ixt,this.PATH.Length - ixt);
    }
    public  void Get_type_path() {
        for (int i = 0; i < this.TYPE_REGISTRY_ARR.Length; i++) {
            int ixt = this.PATH.IndexOf(this.TYPE_REGISTRY_ARR[i]);
            //Console.WriteLine(ixt);
            if (ixt != -1) {
                this.TYPE_REGISTRY = this.TYPE_REGISTRY_ARR[i];
                this.TYPE = i;
            }
        }
        //Console.WriteLine("La ruta es tipo: " + this.TYPE_REGISTRY[type]);
    }
    public void Parameter() {
        int init = TYPE_REGISTRY.Length;
        this.PARAMETER = this.PATH.Substring(init,this.PATH.Length - init);
        if (this.PARAMETER.Length > 1) {    // Elimina los \ en caso tenga // Ejemplo HKEY_CURRENT_USER\ se elimina la ultima \
            this.HAS_PARAMETER = true;
        }
    }
}

[Serializable]
public class InvalidPath : Exception {
    public InvalidPath()
        :base("La ruta ingresada es invalida, debe ingresar una ruta de regedit") { }
    public InvalidPath(string path)
        : base("La ruta "+ path +" es invalida\n"+
                "Ejemplo de ruta válida: \n"+
                @"=> Computer\HKEY_CURRENT_USER\SOFTWARE\"+
                "\n"+ 
                @"=> HKEY_CURRENT_USER\SOFTWARE\") { }
}
[Serializable]
public class EmptyValueName: Exception {
    public EmptyValueName()
        : base("El nombre del valor no puede estár vacía") {
    }
}
public class StringSintax : Exception {
    public StringSintax()
        : base("verifique la sintaxis, no se permite caracteres especiales.") { }
}
[Serializable]
public class EmptyPath : Exception {
    public EmptyPath()
        : base("La ruta está vacía\n"+
                "Ejemplo de ruta válida: \n" +
                @"=> Computer\HKEY_CURRENT_USER\SOFTWARE\" +
                "\n" + 
                @"=> HKEY_CURRENT_USER\SOFTWARE\") { }
}
