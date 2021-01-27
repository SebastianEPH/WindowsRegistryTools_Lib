using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;  //Librería importante 
using System.Threading.Tasks;


public class RegistryWin {

    public string PATH = "";
    public int TYPE = -1; 
    public string[] TYPE_REGISTRY = {"HKEY_CLASSES_ROOT",
                                    "HKEY_CURRENT_USER",
                                    "HKEY_LOCAL_MACHINE",
                                    "HKEY_USERS",
                                    "HKEY_CURRENT_CONFIG"};

    public RegistryWin(string path) {
        this.PATH = path;
        if (!check_path()) {
           throw new InvalidPath();
        }

        
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





    public bool check_path() {  // Verifica si la ruta es correcta
        bool pass = false;
        for (int i = 0; i < this.TYPE_REGISTRY.Length; i++) {
            int ixt = this.PATH.IndexOf(this.TYPE_REGISTRY[i]);
            Console.WriteLine(ixt);
            if (ixt != -1) {
                Console.WriteLine(ixt + " $$ " + this.TYPE_REGISTRY[i]);
                return true;
                //return false;// mandar error de path incorrecto 
                // tambien se puede mandar error de path vacio
            } 
        }
        return pass;
    }
    public void clear_path() { // Elimina el subpath de la ruta ingresada por el usuario
        int ixt = this.PATH.IndexOf(@"HKEY_");
        this.PATH = this.PATH.Substring(ixt,this.PATH.Length - ixt);
    }
    public  int get_type_path() {
        int type = 0;
        for (int i = 0; i < this.TYPE_REGISTRY.Length; i++) {
            int ixt = this.PATH.IndexOf(this.TYPE_REGISTRY[i]);
            //Console.WriteLine(ixt);
            if (ixt != -1) {
                type = i;
            }
        }
        //Console.WriteLine("La ruta es tipo: " + this.TYPE_REGISTRY[type]);
        return type;
    }
    public string get_only_path() {


        return "";
    }


}

[Serializable]
public class InvalidPath : Exception {
    public InvalidPath()
      : base("La ruta ingresada es invalida") { }

}

