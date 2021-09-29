using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    class PasosViewModel : BaseViewModel {
        private ObservableCollection<PasoViewModel<Paso>> _pasos;        
        private int _selectedPasoIndex;
        private ObservableCollection<string> _pasosString;

        public TipoPaso CurrentTipoPaso { get; set; }
        
        public BaseCommand DeleteCommand { get; set; }
        public BaseCommand AddCommand { get; set; }

        public PasosViewModel() {
            _pasos = new ObservableCollection<PasoViewModel<Paso>>();
            _pasosString = new ObservableCollection<string>();
            DeleteCommand = new BaseCommand(OnDeletePaso, CanDeletePaso);
            AddCommand = new BaseCommand(OnAddPaso, CanAddPaso);
        }

        public bool CanAddPaso(object obj) {
             return true;
        }

        private void OnAddPaso(object obj) {
            PasoViewModel<Paso> p;

            switch (CurrentTipoPaso) {
                case TipoPaso.SQL:
                    p = new PasoSQLViewModel();
                    p.NroPaso = _pasos.Count + 1;
                    break;

                case TipoPaso.Stored_Procedure:
                    p = new PasoSPViewModel();
                    p.NroPaso = _pasos.Count + 1;                
                    break;

                case TipoPaso.Job:
                    p = new PasoJobViewModel();
                    p.NroPaso = _pasos.Count + 1;
                    break;

                case TipoPaso.Copia_Archivos:
                    p = new PasoCopiaArchivosViewModel();
                    p.NroPaso = _pasos.Count + 1;
                    break;

                case TipoPaso.Eliminacion_Archivos:
                    p = new PasoEliminacionArchivosViewModel();
                    p.NroPaso = _pasos.Count + 1;

                    break;

                case TipoPaso.Sh:
                    p = new PasoSHViewModel();
                    p.NroPaso = _pasos.Count + 1;

                    break;

                default:
                    p = null;
                    break;
            }

            Dialogs.DialogService.DialogViewModelBase vm = new Dialogs.DialogAddPaso.DialogAddPasoViewModel(p);
            Dialogs.DialogService.DialogResult result = Dialogs.DialogService.DialogService.OpenDialog(vm);
            
            if (result == Dialogs.DialogService.DialogResult.Yes) {
                _pasos.Add(p);                
                _pasos = new ObservableCollection<PasoViewModel<Paso>>(_pasos.OrderBy(x => x.NroPaso).ToList());
                
                _pasosString.Clear();
                foreach (PasoViewModel<Paso> paso in _pasos)
                    _pasosString.Add(paso.DataObject.ToStringFormat("Prod"));

                RaisePropertyChanged("Pasos");
            }
        }

        private bool CanDeletePaso(object obj) {
            return _selectedPasoIndex >= 0 && _pasosString.Count > 0;
        }

        private void OnDeletePaso(object obj) {
            _pasos.Remove(_pasos.ElementAt(_selectedPasoIndex));
            _pasos = new ObservableCollection<PasoViewModel<Paso>>(_pasos.OrderBy(x => x.NroPaso).ToList());

            _pasosString.Clear();
            foreach (PasoViewModel<Paso> p in _pasos)
                _pasosString.Add(p.DataObject.ToStringFormat("Prod"));
        }

        public ObservableCollection<PasoViewModel<Paso>> Pasos {
            get { return _pasos; }
            set {
                _pasos = value;
                RaisePropertyChanged("Pasos");
                RaisePropertyChanged("PasosString");
            }
        }

        public int SelectedPasoIndex {
            get { return _selectedPasoIndex; }
            set {
                _selectedPasoIndex = value;
                RaisePropertyChanged("SelectedPasoIndex");                
            }
        }

        public List<Paso> PasosToList() {
            List<Paso> newList = new List<Paso>();

            foreach (PasoViewModel<Paso> p in _pasos) {
                newList.Add(p.DataObject);
            }

            return newList;
        }

        public void PasosFromList(List<Paso> pasos) {
            PasoViewModel<Paso> p = null;

            foreach (Paso paso in pasos) {
                switch (paso.TipoDePaso) {
                    case TipoPaso.SQL:
                        p = new PasoSQLViewModel((PasoSQL)paso);                        
                        break;

                    case TipoPaso.Stored_Procedure:
                        p = new PasoSPViewModel((PasoSP)paso);                        
                        break;

                    case TipoPaso.Job:
                        p = new PasoJobViewModel((PasoJob)paso);
                        p.NroPaso = _pasos.Count + 1;
                        break;

                    case TipoPaso.Copia_Archivos:
                        p = new PasoCopiaArchivosViewModel((PasoCopiaArchivos)paso);
                        p.NroPaso = _pasos.Count + 1;
                        break;

                    case TipoPaso.Eliminacion_Archivos:
                        p = new PasoEliminacionArchivosViewModel((PasoEliminacionArchivos)paso);
                        p.NroPaso = _pasos.Count + 1;

                        break;

                    case TipoPaso.Sh:
                        p = new PasoSHViewModel((PasoSH)paso);
                        p.NroPaso = _pasos.Count + 1;

                        break;

                    default:
                        p = null;
                        break;
                }
                _pasos.Add(p);
                _pasosString.Add(p.DataObject.ToStringFormat("PROD"));
            }
        }

        public ObservableCollection<string> PasosString {
            get {                
                return _pasosString; 
            }
            set {
                _pasosString = value;
                RaisePropertyChanged("PasosString");
            }
        }

        public override string GetValidationError(string propertyName) {
            return null;
        }
    }
}
