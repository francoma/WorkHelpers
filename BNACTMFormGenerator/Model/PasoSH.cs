using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNACTMFormGenerator.Model
{
    public class PasoSH : Paso {
        public string BaseDatosTest;
        public string BaseDatosProd;
        public string UsuarioEjecucionTest;
        public string UsuarioEjecucionProd;
        public string UbicacionScriptTest;
        public string UbicacionScriptProd;
        public string Script;
        public ObservableCollection<string> Parametros;

        public PasoSH() {
            TipoDePaso = TipoPaso.Sh;
            TextoPaso = "Ejecutar el shell script UNIX";
            ServidorTest = String.Empty;
            ServidorProd = String.Empty;
            BaseDatosTest = "SBLTST";
            BaseDatosProd = "SBLPRD";
            UsuarioEjecucionTest = "siebelq";
            UsuarioEjecucionProd = "siebelp";
            UbicacionScriptTest = "/opt/siebel";
            UbicacionScriptProd = "/opt/siebel";
            Script = String.Empty;
            NroPaso = 1;
        }

        override public string ToStringFormat(string format) {
            string retStr = "PASO " + NroPaso + "\n" + TextoPaso + "\n";
            retStr += "Nombre Script: " + Script;

            if (format.ToUpper() == "TEST") {
                retStr += "\nServidor: " + ServidorTest + "\nBase de Datos: " + BaseDatosTest + "\nUsuario de ejecución sh: " + UsuarioEjecucionTest + "\n";
                retStr += "Ubicación Origen: " + UbicacionScriptTest;            
            } else if (format.ToUpper() == "PROD") {
                retStr += "\nServidor: " + ServidorProd + "\nBase de Datos: " + BaseDatosProd + "\nUsuario de ejecución sh: " + UsuarioEjecucionProd + "\n";
                retStr += "Ubicación Origen: " + UbicacionScriptProd;                        
            }

            retStr += (Parametros == null ? "\n" : "\nParámetros:\n");
            for (int i = 0; i < (Parametros == null ? -1 : Parametros.Count); i++) {
                retStr += "\tParam" + i + ": " + Parametros.ElementAt(i) + "\n";
            }

            return retStr;
        }

        static readonly string[] ValidatedProperties = 
        { 
            "BaseDatosTest",
            "BaseDatosProd",
            "UsuarioEjecucionTest",
            "UsuarioEjecucionProd",
            "UbicacionScriptTest",
            "UbicacionScriptProd",
            "Script",
            "Parametros",
            "TipoDePaso",
            "ServidorTest",
            "ServidorProd",       
            "NroPaso",
            "TextoPaso"
        };

        override public string GetValidationError(string propertyName) {
            if (Array.IndexOf(ValidatedProperties, propertyName) < 0)
                return null;

            string error = null;

            switch (propertyName) {
                case "BaseDatosTest":
                    error = IsStringMissing(BaseDatosTest) ? "El nombre de la Base de Datos de Test es requerido" : null;
                    break;

                case "BaseDatosProd":
                    error = IsStringMissing(BaseDatosProd) ? "El nombre de la Base de Datos de Prod es requerido" : null;
                    break;

                case "UsuarioEjecucionTest":
                    error = IsStringMissing(UsuarioEjecucionTest) ? "El usuario de Test es requerido" : null;
                    break;

                case "UsuarioEjecucionProd":
                    error = IsStringMissing(UsuarioEjecucionTest) ? "El usuario de Prod es requerido" : null;
                    break;

                case "UbicacionScriptTest":
                    error = IsStringMissing(UbicacionScriptTest) ? "La ubicación del script en Test es requerida" : null;
                    break;

                case "UbicacionScriptProd":
                    error = IsStringMissing(UbicacionScriptTest) ? "La ubicación del script en Prod es requerida" : null;
                    break;

                case "Script":
                    error = IsStringMissing(Script) ? "El nombre del Script es requerido" : null;
                    break;

                case "ServidorTest":
                    error = IsStringMissing(ServidorTest) ? "El nombre del servidor de Test es requerido" : null;
                    break;

                case "ServidorProd":
                    error = IsStringMissing(ServidorProd) ? "El nombre del servidor de Prod es requerido" : null;
                    break;
            }

            return error;
        }

        override public bool IsValid {
            get {
                foreach (string property in ValidatedProperties)
                    if (GetValidationError(property) != null) return false;
                return true;
            }
        } 

    }
}
