using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    class PasoJobViewModel : PasoViewModel<Paso> {
        private string _selectedParam;
        public string NewParam { get; set; }

        public BaseCommand AddParam  { get; set; }
        public BaseCommand DelParam { get; set; }

        public PasoJobViewModel() : base(new PasoJob()) {
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
            get { return ((PasoJob)DataObject).Parametros; }
            set {                
                PasoJob psp = (PasoJob)DataObject;
                psp.Parametros = value;

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

        public string NombreJobCTMTest {
            get { return ((PasoJob)DataObject).NombreJobCTMTest; }
            set
            {
                PasoJob pjob = (PasoJob)DataObject;

                if (pjob.NombreJobCTMTest != value) {
                    pjob.NombreJobCTMTest = value;
                    RaisePropertyChanged("NombreJobCTMTest");
                }
            }
        }

        public string NombreJobCTMProd {
            get { return ((PasoJob)DataObject).NombreJobCTMProd; }
            set {
                PasoJob pjob = (PasoJob)DataObject;

                if (pjob.NombreJobCTMProd != value) {
                    pjob.NombreJobCTMProd = value;
                    RaisePropertyChanged("NombreJobCTMProd");
                }
            }
        }

        override public string GetValidationError(string propertyName) {
            return ((PasoJob)DataObject).GetValidationError(propertyName);
        }

        public override bool IsValid {
            get {
                return ((PasoJob)DataObject).IsValid;
            }
        }

    }
}
