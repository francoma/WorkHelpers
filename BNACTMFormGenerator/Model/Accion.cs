using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNACTMFormGenerator.Helpers;

namespace BNACTMFormGenerator.Model
{
    class Accion : DataErrorInfoBase {
        public string TextoBuscado { get; set; }
        public string TextoAccion { get; set; }

        public Accion() {
            TextoAccion = "Enviar aviso a la casilla AyDS_AplicativosEspecialesAPC@bna.com.ar";
        }

        public Accion(string txtBuscado, string txtAccion) {
            TextoBuscado = txtBuscado;
            TextoAccion = txtAccion;
        }

        static readonly string[] ValidatedProperties = 
        { 
            "TextoBuscado", 
            "TextoAccion", 
        };

        override public string GetValidationError(string propertyName) {
            if (Array.IndexOf(ValidatedProperties, propertyName) < 0)
                return null;

            string error = null;

            switch (propertyName) {
                case "TextoBuscado":
                    if (String.IsNullOrEmpty(TextoBuscado) || TextoBuscado.Trim() == String.Empty)
                        error = "El texto o código de error a buscar es requerido";
                    break;

                case "TextoAccion":
                    if (String.IsNullOrEmpty(TextoAccion) || TextoAccion.Trim() == String.Empty)
                        error = "La Acción es requerida";
                    break;

                default:
                    error = "Propiedad de Accion inexistente";
                    break;
            }
            return error;
        }
    }
}
