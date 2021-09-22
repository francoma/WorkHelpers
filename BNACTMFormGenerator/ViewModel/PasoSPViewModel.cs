using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    class PasoSPViewModel : PasoViewModel<Paso> {        
        private string _selectedParam;
        public string NewParam { get; set; }
        public BaseCommand AddParam {get; set;}
        public BaseCommand DelParam { get; set; }

        public PasoSPViewModel() : base(new PasoSP()) {
            NewParam = "";
            AddParam = new BaseCommand(OnAddParam, param => NewParam.Trim().Length > 0);
            DelParam = new BaseCommand(OnDelParam, param => _selectedParam != null);
        }

        public PasoSPViewModel(PasoSP p) : base(p) {
            NewParam = "";
            AddParam = new BaseCommand(OnAddParam, param => NewParam.Trim().Length > 0);
            DelParam = new BaseCommand(OnDelParam, param => _selectedParam != null);
        }

        public void OnAddParam(object obj) {
            if (Parametros == null) {
                Parametros = new ObservableCollection<string>();
            }
            Parametros.Add(NewParam);
            NewParam = "";
            RaisePropertyChanged("NewParam");
            RaisePropertyChanged("Parametros");
        }

        public void OnDelParam(object obj) {
            Parametros.Remove(SelectedParam);
            RaisePropertyChanged("Parametros");
            RaisePropertyChanged("SelectedParam");
        }


        public ObservableCollection<string> Parametros {
            get {  return ((PasoSP)DataObject).parametros; }
            set {                
                PasoSP psp = (PasoSP)DataObject;
                psp.parametros = value;

                RaisePropertyChanged("Parametros");
            }
        }

        public string SelectedParam {
            get { return _selectedParam; }
            set {
                if (_selectedParam != value) {
                    _selectedParam = value;
                    RaisePropertyChanged("SelectedParam");
                }
            }
        }

        public string BaseDatosTest{
            get {return ((PasoSP)DataObject).BaseDatosTest;}
            set {
                PasoSP psql = (PasoSP)DataObject;

                if (psql.BaseDatosTest != value){
                    psql.BaseDatosTest = value;
                    RaisePropertyChanged("BaseDatosTest");
                }
            }
        }

        public string BaseDatosProduccion {
            get { return ((PasoSP)DataObject).BaseDatosProduccion; }
            set {
                PasoSP psql = (PasoSP)DataObject;

                if (psql.BaseDatosProduccion != value) {
                    psql.BaseDatosProduccion = value;
                    RaisePropertyChanged("BaseDatosProduccion");
                }
            }
        }

        public string UsuarioEjecucion {
            get { return ((PasoSP)DataObject).UsuarioEjecucion; }
            set {
                PasoSP psql = (PasoSP)DataObject;

                if (psql.UsuarioEjecucion != value) {
                    psql.UsuarioEjecucion = value;
                    RaisePropertyChanged("UsuarioEjecucion");
                }                
            }
        }

        public string StoredProcedure {
            get { return ((PasoSP)DataObject).StoredProcedure; }
            set {
                PasoSP psp = (PasoSP)DataObject;

                if (psp.StoredProcedure != value) {
                    psp.StoredProcedure = value;
                    RaisePropertyChanged("StoredProcedure");
                }
            }
        }

        override public string GetValidationError(string propertyName) {
            return ((PasoSP)DataObject).GetValidationError(propertyName);
        }

        public override bool IsValid {
            get {
                return ((PasoSP)DataObject).IsValid;
            }
        }
    }
}

