using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNACTMFormGenerator.Model
{
    [Serializable()]
    public class PasoEliminacionArchivos : Paso {
        public string RutaTest;
        public string RutaProd;
        public string ArchivosOPatron;

        public PasoEliminacionArchivos() {
            TipoDePaso = TipoPaso.Eliminacion_Archivos;
            TextoPaso = "Eliminación de archivos";
            ServidorTest = String.Empty;
            ServidorProd = String.Empty;
            NroPaso = 1;            
        }

        override public string ToStringFormat(string format) {
            string retStr = "PASO " + NroPaso + "\n" + TextoPaso + "\n";

            if (format.ToUpper() == "TEST") 
                retStr += "Servidor: " + ServidorTest + "\nUbicación: " + RutaTest + "\nArchivos o Patrón: " + ArchivosOPatron + "\n\n";
            else if (format.ToUpper() == "PROD")
                retStr += "Servidor: " + ServidorProd + "\nUbicación: " + RutaProd + "\nArchivos o Patrón: " + ArchivosOPatron + "\n\n";

            return retStr;
        }

        static readonly string[] ValidatedProperties = 
        { 
            "RutaTest",
            "RutaProd",
            "ArchivosOPatron",
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
                case "RutaTest":
                    error = IsStringMissing(RutaTest) ? "La ruta de Test es requerida" : null;
                    break;

                case "RutaProd":
                    error = IsStringMissing(RutaProd) ? "La ruta de Prod es requerida" : null;
                    break;

                case "ArchivosOPatron":
                    error = IsStringMissing(ArchivosOPatron) ? "Los archivos o el patrón de archivos a eliminar son/es requerido" : null;
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
