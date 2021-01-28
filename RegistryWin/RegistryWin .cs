using System;
using Microsoft.Win32;  //Librería importante 

public class RegistryWin {

    public string PATH = "";    // PATH Limpio 
    private int TYPE = -1;
    public string TYPE_REGISTRY = "";
    public string CURRENT_KEY = "";
    public string PARAMETER_SUBT_KEY = "";
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
        GetCurrentKey(); // Obtiene key actual, solo si si HAS_PARAMETER es True
        GetParameterSubtKey(); // Obtiene los parametros sin key 
                         // Si existe parametros, obtiene el nombre del ultimo key
                         // path sin subpath y sin key




    }

    public void CreateKey(string keyName) {
        CheckKeyname(keyName);
        try {
            Registry.SetValue(this.PATH + @"\" + keyName,"","");
        } catch (Exception) {
            Registry.SetValue(this.PATH + keyName,"","");
        }

    }
    public void DeleteKey() {
        if (!HAS_PARAMETER) {
            // mandar excepcion, por que no puedes eliminar con una ruta sin key 
        }else {
            OpenKey(true);
           // k = Registry.ClassesRoot.OpenSubKey(GetSubFilesSinKeyName(path),true);
            //k.DeleteSubKeyTree(GetkeyName(path)); 
            k.Close();
        }
    }
   
    public void ReadValue() {

    }
    

    public void SetValue_String(string valueName, string valueData) {
        CheckValue(valueName);
       // OpenKey();
        try {
           k.SetValue(valueName,valueData,RegistryValueKind.String);
           k.Close();
        } catch {
            throw new StringSintax();
        }
        
    }
    public void SetValue_Binary(string valueName, byte[] valueData) {
        CheckValue(valueName);
        OpenKey();
        try {
            k.SetValue(valueName,valueData,RegistryValueKind.Binary);
            k.Close();
        } catch {
            throw new StringSintax();
        }
    }
    public void SetValue_DWORD (string valueName, Int32 valueData) {
        CheckValue(valueName);
        OpenKey();
        try {
            k.SetValue(valueName,valueData,RegistryValueKind.DWord);
            k.Close();
        } catch {
            throw new StringSintax();
        }
    }
    public void SetValue_QWORD(string valueName,Int64 valueData) {
        CheckValue(valueName);
        OpenKey();
        try {
            k.SetValue(valueName,valueData,RegistryValueKind.QWord);
            k.Close();
        } catch {
            throw new StringSintax();
        }
    }
    public void SetValue_MultiString(string valueName, String[] valueData) {
        CheckValue(valueName);
        OpenKey();
        try {
            k.SetValue(valueName,valueData,RegistryValueKind.MultiString);
            k.Close();
        } catch {
            throw new StringSintax();
        }
    }
    public void SetValue_ExpandableString(string valueName,string valueData) {
        SetValue_String(valueName,valueData);
    }
    public void DeleteValue(string valueName) {
        CheckValue(valueName);
        OpenKey();
        try {
            k.DeleteValue(valueName);
            k.Close();
        } catch {
            throw new StringSintax();
        }
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
    private void CheckKeyname(string keyName) {
        if (keyName.Equals("")) {
            throw new EmptyKeyName();
        }
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
    private void Clear_path() { // Elimina sobrantes de la ruta ingresada por el usuario
        int ixt = this.PATH.IndexOf(@"HKEY_");
        this.PATH = this.PATH.Substring(ixt,this.PATH.Length - ixt);
    }
    private void Get_type_path() {
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
    private void GetCurrentKey() {
        if (HAS_PARAMETER) {
            int ixt = this.PATH.LastIndexOf(@"\") + 1;
            this.CURRENT_KEY =  this.PATH.Substring(ixt,this.PATH.Length - ixt);
        }
        // Else no tiene parametros
    }
    private void GetParameterSubtKey() {
        if (HAS_PARAMETER) {
            try {
                int key = this.PATH.LastIndexOf(@"\");   // onlyKey 
                int ixt = this.PATH.IndexOf(@"\") + 1;
                PARAMETER_SUBT_KEY = this.PATH.Substring(ixt,key - ixt);
            } catch (Exception) {
                PARAMETER_SUBT_KEY = "";
            }
        }
    }
    private void Parameter() {
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
public class EmptyKeyName : Exception {
    public EmptyKeyName()
        : base("La El nombre de la llave no puede estár vacía ") {
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
