using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNACTMFormGenerator.Model
{
    public class PasoSQL : Paso {
        public string BaseDatosTest;
        public string BaseDatosProduccion;
        public string UsuarioEjecucion;
        public string TextoSQL;

        public PasoSQL(string servidorTest, string servidorProd, string dbTst, string dbProd, string usr, int nroPaso, string sqlTxt)
            : base(TipoPaso.SQL, servidorTest, servidorProd, nroPaso) {
            BaseDatosTest = dbTst;
            BaseDatosProduccion = dbProd;
            UsuarioEjecucion = usr;
            TextoPaso = "Ejecutar SQL a través del módulo de SQLPLUS de CONTROLM:";
            TextoSQL = sqlTxt;
        }

        public PasoSQL() {            
            TipoDePaso = TipoPaso.SQL;
            TextoPaso = "Ejecutar SQL a través del módulo de SQLPLUS de CONTROLM:";
            ServidorTest = "[TUX80CT0001 | TUX80AT0001 (utilizar este último en caso de fallo del CT)]";
            ServidorProd = "[SUX80CT0001 | SUX80AT0001 (utilizar este último en caso de fallo del CT)]";
            BaseDatosTest = "SBLTST";
            BaseDatosProduccion = "SBLPRD";
            TextoSQL = @"set echo ON 
set termout ON
set serveroutput ON
whenever sqlerror exit SQL.SQLCODE
exit";
            NroPaso = 1;
            UsuarioEjecucion = "";
        }

        public override string ToString() {
            string retStr = "PASO " + NroPaso + "\n" + TextoPaso + "\n";
            retStr += TextoSQL + "\n";
            retStr += "Servidor Test: " + ServidorTest + "\n" + "Servidor Prod: " + ServidorProd + "\n";
            retStr += "Base de Datos Test: " + BaseDatosTest + "\n" + "Base de Datos Prod: " + BaseDatosProduccion + "\n";
            retStr += "Usuario de ejecución SQL: " + UsuarioEjecucion + "\n\n";

            return retStr;
        }
        
        override public string ToStringFormat(string format) {
            string retStr = "PASO " + NroPaso + "\n" + TextoPaso + "\n" + TextoSQL + "\n";
            
            if (format.ToUpper() == "TEST") {
                retStr += "Servidor: " + ServidorTest + "\n";
                retStr += "Base de Datos: " + BaseDatosTest + "\n";
            }
            else if (format.ToUpper() == "PROD") {
                retStr += "Servidor: " + ServidorProd + "\n";
                retStr += "Base de Datos: " + BaseDatosProduccion + "\n";                
            }

            retStr += "Usuario de ejecución SQL: " + UsuarioEjecucion + "\n\n";
            return retStr;
        }

        static readonly string[] ValidatedProperties = 
        { 
            "BaseDatosTest",
            "BaseDatosProduccion",
            "UsuarioEjecucion",
            "TextoSQL",
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
            
            switch(propertyName) {
                case "BaseDatosTest":
	                error = IsStringMissing(BaseDatosTest) ? "El nombre de la Base de Datos de Test es requerido" : null;
                 break;
 
                 case "BaseDatosProduccion":
	                error = IsStringMissing(BaseDatosProduccion) ? "El nombre de la Base de Datos de Prod es requerido" : null;
                 break;
 
                 case "UsuarioEjecucion":
	                error = IsStringMissing(UsuarioEjecucion) ? "El usuario es requerido" : null;
                 break;
 
                 case "TextoSQL":
 	                error = IsStringMissing(TextoSQL) ? "El texto SQL es requerido" : null;
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


