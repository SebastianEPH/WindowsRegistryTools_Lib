using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;  //Librería importante 
using System.Threading.Tasks;


public class RegistryWin {

    public string PATH = "";    // PATH Limpio 
    private int TYPE = -1;
    public string TYPE_REGISTRY = "";
    public bool HAS_PARAMETER = false; // Tiene parametros
    public string PARAMETER = "";

    private string[] TYPE_REGISTRY_ARR = {"HKEY_CLASSES_ROOT",
                                    "HKEY_CURRENT_USER",
                                    "HKEY_LOCAL_MACHINE",
                                    "HKEY_USERS",
                                    "HKEY_CURRENT_CONFIG"};

    public RegistryWin(string path) {
        this.PATH = path;
        check_path();   // Verifica si la ruta es correcta o manda una excepción 
        clear_path();   // limpia ruta
        get_type_path();// Obtiene el tipo de registro
        parameter();     // Obtiene Parametros
            // Si existe parametros, obtiene el nombre del ultimo key
            // path sin subpath y sin key


    }

    public void createKey() {

    }
    public void deleteKey() {

    }
    public void createValue() {

    }
    public void readValue() {

    }
    public void setValue_String() {

    }
    public void setValue_Binary() {

    }
    public void setValue_DWORD() {

    }
    public void setValue_QWORD() {

    }
    public void setValue_MultiString() {

    }
    public void setValue_ExpandableString() {

    }
    public void deleteValue() {

    }


    private void check_path() {  // Verifica si la ruta es correcta
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
    private void clear_path() { // Elimina el subpath de la ruta ingresada por el usuario
        int ixt = this.PATH.IndexOf(@"HKEY_");
        this.PATH = this.PATH.Substring(ixt,this.PATH.Length - ixt);
    }
    public  void get_type_path() {
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
    public void parameter() {
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
public class EmptyPath : Exception {
    public EmptyPath()
        : base("La ruta está vacía\n"+
                "Ejemplo de ruta válida: \n" +
                @"=> Computer\HKEY_CURRENT_USER\SOFTWARE\" +
                "\n" + 
                @"=> HKEY_CURRENT_USER\SOFTWARE\") { }
}
