using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNACTMFormGenerator.Helpers;
using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    public class AccionViewModel : BaseViewModel {
        private Accion _accion;

        public AccionViewModel() {
            _accion = new Accion();
        }

        public AccionViewModel(Accion accion) {
            _accion = accion;
        }

        public string TextoBuscado {
            get { return _accion.TextoBuscado; }
            set {
                if (_accion.TextoBuscado != value) {
                    _accion.TextoBuscado = value;
                    RaisePropertyChanged("TextoBuscado");
                }
            }
        }

        public string TextoAccion {
            get { return _accion.TextoAccion; }
            set {
                if (_accion.TextoAccion != value) {
                    _accion.TextoAccion = value;
                    RaisePropertyChanged("TextoAccion");
                }
            }
        }

        public Accion Accion {
            get { return _accion; }
            set {
                if (_accion != value) {
                    _accion = value;
                    RaisePropertyChanged("TextoBuscado");
                    RaisePropertyChanged("TextoAccion");
                }
            }
        }

        override public string GetValidationError(string propertyName) {
            return _accion.GetValidationError(propertyName);
        }
    }
}
