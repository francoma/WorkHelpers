using System;
using System.Xml.Serialization;
using BNACTMFormGenerator.Helpers;

namespace BNACTMFormGenerator.Model
{
    [Serializable()]
    public enum TipoPaso
    {
        SQL,
        Stored_Procedure,
        Job,
        Copia_Archivos,
        Eliminacion_Archivos,
        Sh
    }
    
    [Serializable()]
    [XmlInclude(typeof(PasoSQL))]
    [XmlInclude(typeof(PasoSP))]
    [XmlInclude(typeof(PasoJob))]
    [XmlInclude(typeof(PasoCopiaArchivos))]
    [XmlInclude(typeof(PasoEliminacionArchivos))]
    [XmlInclude(typeof(PasoSH))]
    public class Paso : DataErrorInfoBase {
        public TipoPaso TipoDePaso;
        public string ServidorTest;
        public string ServidorProd;        
        public int NroPaso;
        public string TextoPaso;

        public Paso(TipoPaso paso, string servidorTest, string servidorProd, int nroPaso) {
            ServidorTest = servidorTest;
            ServidorProd = servidorProd;
            TipoDePaso = paso;
            TextoPaso = "Paso generico";
            NroPaso = nroPaso;
        }

        public Paso() {
            ServidorTest = "TESTSRV";
            ServidorTest = "PRODSRV";
            TextoPaso = "Paso generico";
            NroPaso = 1;
        }
        
        virtual public string ToStringFormat(string format) {
            string retStr = "PASO " + NroPaso + "\n" + TextoPaso + "\n";

            if (format == "TEST") {
                retStr += "Servidor: " + ServidorTest + "\n";                
            } else if (format == "PROD") {
                retStr += "Servidor: " + ServidorProd + "\n";                
            }
            
            return retStr;
        }

        static readonly string[] ValidatedProperties = {        
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

            switch (propertyName)   {
                case "ServidorTest":
                    error = IsStringMissing(ServidorTest) ? "El nombre del servidor de Test es requerido" : null;
                    break;
                case "ServidorProd":
                    error = IsStringMissing(ServidorTest) ? "El nombre del servidor de Prod es requerido" : null;
                    break;
            }

            return error;
        }
    }
}
