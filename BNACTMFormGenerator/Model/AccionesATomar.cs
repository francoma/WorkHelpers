using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNACTMFormGenerator.Helpers;
using BNACTMFormGenerator.ViewModel;

namespace BNACTMFormGenerator.Model
{
    [Serializable()]
    public class AccionesATomar : DataErrorInfoBase {
        public int HoraAccionNoInicia;
        public int MinutosAccionNoInicia;
        public string AvisoNoInicio;
        public string TiempoJobNoFinaliza;
        public string AvisoJobNoFinaliza;
        public ObservableCollection<AccionViewModel> AccionesExitosas;        
        public ObservableCollection<AccionViewModel> AccionesErroneas;

        public AccionesATomar() {
            HoraAccionNoInicia = 0;
            MinutosAccionNoInicia = 0;
            AvisoNoInicio = "Enviar aviso a la casilla AyDS_AplicativosEspecialesAPC@bna.com.ar";
            TiempoJobNoFinaliza = "120 minutos";
            AvisoJobNoFinaliza = "Enviar aviso a la casilla AyDS_AplicativosEspecialesAPC@bna.com.ar";
            AccionesExitosas = new ObservableCollection<AccionViewModel>();
            AccionesErroneas = new ObservableCollection<AccionViewModel>();
        }

        static readonly string[] ValidatedProperties = 
        {             
            "HoraAccionNoInicia",
            "MinutosAccionNoInicia",
            "AvisoNoInicio", 
            "TiempoJobNoFinaliza", 
            "AvisoJobNoFinaliza",
            "AccionesErroneas",
            "AccionesExitosas",
        };

        override public string GetValidationError(string propertyName) {
            if (Array.IndexOf(ValidatedProperties, propertyName) < 0)
                return null;

            string error = null;

            switch (propertyName) {
                case "HoraAccionNoInicia":
                    if (IsStringMissing(AvisoNoInicio))
                        error = "La hora límite a tomar en cuenta si el job no inició es requerida";
                    break;

                case "MinutosAccionNoInicia":
                    if (IsStringMissing(AvisoNoInicio))
                        error = "Los minutos límite a tomar en cuenta si el job no inició son requeridos";
                    break;

                case "AvisoNoInicio":
                    if (IsStringMissing(AvisoNoInicio))
                        error = "El aviso que el Job no inicio no puede estar vacío";
                    break;

                case "TiempoJobNoFinaliza":
                    if (IsStringMissing(TiempoJobNoFinaliza))
                        error = "El tiempo máximo de espera para el Job es requerido";
                    break;

                case "AvisoJobNoFinaliza":
                    if (IsStringMissing(AvisoJobNoFinaliza))
                        error = "El Nombre del Job en Producción es requerido";
                    break;

                case "AccionesErroneas":
                    if (AccionesErroneas.Count == 0)
                        error = "Debe existir al menos una Acción de Error";
                    break;

                case "AccionesExitosas":
                    if (AccionesErroneas.Count == 0)
                        error = "Debe existir al menos una Acción de Exito";
                    break;
            }

            return error;
        }

        override public bool IsValid {
            get {
                foreach (string property in ValidatedProperties) 
                    if (GetValidationError(property) != null) 
                        return false;

                return true;
            }
        }      
    }
}
