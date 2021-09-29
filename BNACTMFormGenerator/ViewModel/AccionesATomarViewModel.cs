using System.Collections.ObjectModel;
using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    class AccionesATomarViewModel : BaseViewModel {
        private AccionesATomar _accionesATomar;
        private AccionViewModel _selectedAccionExitosa;
        public BaseCommand DeleteCommandAccionExitosa { get; set; }
        public BaseCommand AddCommandAccionExitosa { get; set; }

        private AccionViewModel _selectedAccionErronea;
        public BaseCommand DeleteCommandAccionErronea { get; set; }
        public BaseCommand AddCommandAccionErronea { get; set; }


        public AccionesATomarViewModel() {
            _accionesATomar = new AccionesATomar();

            DeleteCommandAccionExitosa = new BaseCommand(OnDeleteAccionExitosa, CanDeleteAccionExitosa);
            AddCommandAccionExitosa = new BaseCommand(OnAddAccionExitosa, CanAddAccionExitosa);
                        
            DeleteCommandAccionErronea = new BaseCommand(OnDeleteAccionErronea, CanDeleteAccionErronea);
            AddCommandAccionErronea = new BaseCommand(OnAddAccionErronea, CanAddAccionErronea);
        }

        public AccionesATomar DataObject {
            get { return _accionesATomar; }
            set {
                _accionesATomar = value;
                RaisePropertyChanged("DataObject");
            }
        }

        public int SelectedIndexHoraNoInicia {
            get { return _accionesATomar.HoraAccionNoInicia; }
            set {
                if (_accionesATomar.HoraAccionNoInicia != value) {
                    _accionesATomar.HoraAccionNoInicia = value;
                    RaisePropertyChanged("SelectedIndexHoraNoInicia");
                }
            }
        }

        public int SelectedIndexMinutosNoInicia {
            get { return _accionesATomar.MinutosAccionNoInicia; }
            set {
                if (_accionesATomar.MinutosAccionNoInicia != value) {
                    _accionesATomar.MinutosAccionNoInicia = value;
                    RaisePropertyChanged("SelectedIndexMinutosNoInicia");
                }
            }
        }

        public string AvisoNoInicio {
            get { return _accionesATomar.AvisoNoInicio; }
            set {
                if (_accionesATomar.AvisoNoInicio != value) {
                    _accionesATomar.AvisoNoInicio = value;
                    RaisePropertyChanged("AvisoNoInicio");
                }
            }
        }

        public string TiempoJobNoFinaliza {
            get { return _accionesATomar.TiempoJobNoFinaliza; }
            set {
                if (_accionesATomar.TiempoJobNoFinaliza != value) {
                    _accionesATomar.TiempoJobNoFinaliza = value;
                    RaisePropertyChanged("TiempoJobNoFinaliza");
                }
            }
        }

        public string AvisoJobNoFinaliza {
            get { return _accionesATomar.AvisoJobNoFinaliza; }
            set {
                if (_accionesATomar.AvisoJobNoFinaliza != value) {
                    _accionesATomar.AvisoJobNoFinaliza = value;
                    RaisePropertyChanged("AvisoJobNoFinaliza");
                }
            }
        }

        public ObservableCollection<AccionViewModel> AccionesExitosas {
            get { return _accionesATomar.AccionesExitosas; }
            set {
                _accionesATomar.AccionesExitosas = value;
                RaisePropertyChanged("AccionesExitosas");                
            }
        }

        public AccionViewModel SelectedAccionExitosa {
            get { return _selectedAccionExitosa; }
            set {
                    _selectedAccionExitosa = value;
            }
        }

        public ObservableCollection<AccionViewModel> AccionesErroneas {
            get { return _accionesATomar.AccionesErroneas; }
            set {
                _accionesATomar.AccionesErroneas = value;
                RaisePropertyChanged("AccionesErroneas");                
            }
        }

        public AccionViewModel SelectedAccionErronea {
            get { return _selectedAccionErronea; }
            set {
                _selectedAccionErronea = value;
            }
        }

        #region Command Accion Exitosa
        private void OnDeleteAccionExitosa(object obj) {
            _accionesATomar.AccionesExitosas.Remove(_selectedAccionExitosa);
        }

        private bool CanDeleteAccionExitosa(object obj) {
            return _selectedAccionExitosa != null;
        }

        private void OnAddAccionExitosa(object obj) {
            _accionesATomar.AccionesExitosas.Add(new AccionViewModel());
        }

        private bool CanAddAccionExitosa(object obj) {
            return _accionesATomar.AccionesExitosas.Count <= 6;
        }
        #endregion Command Command Accion Exitosa

        #region Command Accion Erronea
        private void OnDeleteAccionErronea(object obj) {
            _accionesATomar.AccionesErroneas.Remove(_selectedAccionErronea);
        }

        private bool CanDeleteAccionErronea(object obj) {
            return _selectedAccionErronea != null;
        }

        private void OnAddAccionErronea(object obj) {
            _accionesATomar.AccionesErroneas.Add(new AccionViewModel());
        }

        private bool CanAddAccionErronea(object obj) {
            return _accionesATomar.AccionesErroneas.Count <= 6;
        }
        #endregion Command Command Accion Erronea

       
        override public string GetValidationError(string propertyName) {
            return _accionesATomar.GetValidationError(propertyName);    
        }

        public override bool IsValid {
            get {
                return _accionesATomar.IsValid;
            }
        } 
    }
}
