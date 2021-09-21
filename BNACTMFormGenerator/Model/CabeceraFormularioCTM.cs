using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNACTMFormGenerator.Helpers;

namespace BNACTMFormGenerator.Model
{
    public class CabeceraFormularioCTM : DataErrorInfoBase {
        public string Fecha { get; set; }
        public string NombreProc { get; set; }
        public string Usuario { get; set; }
        public string Area { get; set; }
        public string Descr { get; set; }
        public TipoPeriodicidad Periodicidad { get; set; }
        public string DetalleFrecuencia { get; set; }
        public int HoraInicioEjecucion {get; set;}
        public int MinutosInicioEjecucion { get; set; }
        public int HoraLimiteInicioEjecucion { get; set; }
        public int MinutosLimiteInicioEjecucion { get; set; }


        public CabeceraFormularioCTM(string fecha, string nombreProc, string usuario, string area, string descr, TipoPeriodicidad tp, string detalleFrecuencia) {
            Fecha = fecha;
            NombreProc = nombreProc;
            Usuario = usuario;
            Area = area;
            Descr = descr;
            Periodicidad = tp;
            DetalleFrecuencia = detalleFrecuencia;
        }

        public CabeceraFormularioCTM() {
            Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            Usuario = Environment.UserName;
            Area = "Aplicativos Especiales - Sistemas, Organizacion y Sucursales";
            Periodicidad = TipoPeriodicidad.Esporádico;
        }
        
        static readonly string[] ValidatedProperties = 
        { 
            "Fecha", 
            "NombreProc", 
            "Usuario",
            "Area",
            "Descr",
            "Periodicidad",
            "DetalleFrecuencia",
            "HoraInicioEjecucion",
            "MinutosInicioEjecucion",
            "HoraLimiteInicioEjecucion",
            "MinutosLimiteInicioEjecucion"
        };

        override public string GetValidationError(string propertyName) {
            if (Array.IndexOf(ValidatedProperties, propertyName) < 0)
                return null;

            string error = null;

            switch (propertyName) {
                case "Fecha":
                    DateTime dt;
                    bool validDate = DateTime.TryParseExact(Fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt);

                    if (!validDate)
                        error = "Formato de fecha inválido. El formato válido es DD/MM/YYYY";
                    else if (IsStringMissing(Fecha))
                        error = "La Fecha es requerida";
                    break;

                case "NombreProc":
                    if (IsStringMissing(NombreProc))
                        error = "El Nombre del Job es requerido";
                    break;

                case "Usuario":
                    if (IsStringMissing(Usuario))
                        error = "El Usuario es requerido";
                    break;

                case "Area":
                    if (IsStringMissing(Area))
                        error = "El Area es requerida";
                    break;

                case "Descr":
                    if (IsStringMissing(Descr))
                        error = "La descripción del Job es requerida";
                    break;

                case "DetalleFrecuencia":
                    if (IsStringMissing(DetalleFrecuencia))
                        error = "El Detalle de la frecuencia es requerido";
                    break;

                case "HoraInicioEjecucion":
                    if (IsStringMissing(HoraInicioEjecucion.ToString()))
                        error = "La Hora de Inicio de Ejecución es requerida";
                    break;

                case "MinutosInicioEjecucion":
                    if (IsStringMissing(MinutosInicioEjecucion.ToString()))
                        error = "Los Minutos de Inicio de Ejecución son requeridos";
                    break;

                case "HoraLimiteInicioEjecucion":
                    if (IsStringMissing(HoraLimiteInicioEjecucion.ToString()))
                        error = "La Hora Límite de Inicio de Ejecución es requerida";
                    break;

                case "MinutosLimiteInicioEjecucion":
                    if (IsStringMissing(MinutosLimiteInicioEjecucion.ToString()))
                        error = "Los Minutos Límite de Inicio de Ejecución son requeridos";
                    break;
            }

            return error;
        }
    }
}
