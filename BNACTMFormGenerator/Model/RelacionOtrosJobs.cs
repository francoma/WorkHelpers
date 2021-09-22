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
    public class RelacionOtrosJobs : DataErrorInfoBase  {
        public ObservableCollection<JobViewModel> JobsEntrada;
        public ObservableCollection<JobViewModel> JobsSalida;
        public ObservableCollection<JobViewModel> JobsParalelos;
        public string Aclaraciones;

        public RelacionOtrosJobs() {
            JobsEntrada = new ObservableCollection<JobViewModel>();
            JobsSalida = new ObservableCollection<JobViewModel>();
            JobsParalelos = new ObservableCollection<JobViewModel>();
            Aclaraciones = "Este procedimiento no puede correr con otra instancia de si mismo.";
        }

        static readonly string[] ValidatedProperties = 
        { 
            "JobsEntrada",
            "JobsSalida",
            "JobsParalelos",
            "Aclaraciones"
        };

        override public string GetValidationError(string propertyName) {
            if (Array.IndexOf(ValidatedProperties, propertyName) < 0)
                return null;

            string error = null;

            if (propertyName == "Aclaraciones") error = IsStringMissing(Aclaraciones) ? "Las Aclaraciones son requeridas" : null;

            return error;
        }

        public override bool IsValid {
            get {
                foreach (string property in ValidatedProperties)
                    if (GetValidationError(property) != null) return false;
                
                return true;
            }
        }
    }
}
