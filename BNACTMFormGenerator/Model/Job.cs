using System;
using BNACTMFormGenerator.Helpers;

namespace BNACTMFormGenerator.Model
{
    public class Job : DataErrorInfoBase {
        public string NombreJobTest { get; set; }
        public string NombreJobProd { get; set; }

        public Job() { }

        public Job(string nombreProd) {
            NombreJobTest = nombreProd + "T";
            NombreJobProd = nombreProd;
        }

        public Job(string nombreTest, string nombreProd) {
            NombreJobTest = nombreTest;
            NombreJobProd = nombreProd;
        }

        static readonly string[] ValidatedProperties = 
        { 
            "NombreJobTest", 
            "NombreJobProd", 
        };

        override public string GetValidationError(string propertyName) {
            if (Array.IndexOf(ValidatedProperties, propertyName) < 0)
                return null;

            string error = null;

            switch (propertyName) {
                case "NombreJobTest":
                    if (IsStringMissing(NombreJobProd))
                        error = "El Nombre del Job en Test es requerido";
                    break;

                case "NombreJobProd":
                    if (IsStringMissing(NombreJobProd))
                        error = "El Nombre del Job en Producción es requerido";
                    break;

                default:
                    error = "Propiedad de Job inexistente";
                    break;
            }

            return error;
        }
    }
}
