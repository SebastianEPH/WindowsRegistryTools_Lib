using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;  //Librería importante 
using System.Threading.Tasks;


public class RegistryWin {

    public string PATH = "";

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

    private bool check_path(string path) {  // Verifica si la ruta es correcta
        int ixt = path.IndexOf(@"HKEY_");  // obtiene el index
        if (ixt == -1) {
            return false;// mandar error de path incorrecto 
            // tambien se puede mandar error de path vacio
        } else {
            return true;
        }
    }
    private string parse_path(string path) { // Elimina el subpath de la ruta ingresada por el usuario
        int ixt = path.IndexOf(@"HKEY_");  
        return path.Substring(ixt,path.Length - ixt);
    }


}

