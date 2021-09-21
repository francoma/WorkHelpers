using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNACTMFormGenerator.Model
{
    public class PasoJob : Paso {
        public ObservableCollection<string> Parametros;
        public string NombreJobCTMTest;
        public string NombreJobCTMProd;

        public PasoJob() {
            TipoDePaso = TipoPaso.Job;
            TextoPaso = "Ejecución del Job ";
            ServidorTest = "[TUX80CT0001 | TUX80AT0001 (utilizar este último en caso de fallo del CT)]";
            ServidorProd = "[SUX80CT0001 | SUX80AT0001 (utilizar este último en caso de fallo del CT)]";
            NroPaso = 1;            
        }

        public override string ToStringFormat(string format) {
            string retStr = "PASO " + NroPaso + "\n" + TextoPaso; 

            if (format.ToUpper() == "TEST")
                retStr += NombreJobCTMTest +"\nValor de parámetros: \n";
            else if (format.ToUpper() == "PROD")
                retStr += NombreJobCTMProd + "\nValor de parámetros: \n";

            for (int i = 0; i < (Parametros == null ? -1 : Parametros.Count); i++) {
                retStr += "\tParam" + i + ": " + Parametros.ElementAt(i) + "\n";
            }

            if (format.ToUpper() == "TEST") 
                retStr += "Servidor: " + ServidorTest + "\n\n";
            else if (format.ToUpper() == "PROD")
                retStr += "Servidor: " + ServidorProd + "\n\n";

            return retStr;
        }

        static readonly string[] ValidatedProperties = 
        { 
            "NombreJobCTMTest",
            "NombreJobCTMProd",
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

            switch (propertyName)
            {
                case "NombreJobCTMTest":
                    error = IsStringMissing(NombreJobCTMTest) ? "El nombre del Job de Test es requerido" : null;
                    break;

                case "NombreJobCTMProd":
                    error = IsStringMissing(NombreJobCTMProd) ? "El nombre del Job de Prod es requerido" : null;
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
