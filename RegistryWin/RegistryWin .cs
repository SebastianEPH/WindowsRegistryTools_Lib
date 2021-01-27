using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;  //Librería importante 
using System.Threading.Tasks;


public class RegistryWin {

    public string PATH = "";
    public string[] subpath_registry = {"HKEY_CURRENT_USER",
                                    "HKEY_CLASSES_ROOT",
                                    "HKEY_LOCAL_MACHINE",
                                    "HKEY_USERS",
                                    "HKEY_CURRENT_CONFIG"};

    public RegistryWin(string path) {
        this.PATH = path;
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

    private bool check_path(string path, string[] subpath_registry) {  // Verifica si la ruta es correcta
        bool pass = true;
        foreach (string subpath in subpath_registry) {
            int ixt = path.IndexOf(subpath);  // obtiene el index
            if (ixt == -1) {
                pass = false;
                //return false;// mandar error de path incorrecto 
                // tambien se puede mandar error de path vacio
            }
        }
        return pass;
    }
    private string parse_path(string path) { // Elimina el subpath de la ruta ingresada por el usuario
        int ixt = path.IndexOf(@"HKEY_");  
        return path.Substring(ixt,path.Length - ixt);
    }


}

