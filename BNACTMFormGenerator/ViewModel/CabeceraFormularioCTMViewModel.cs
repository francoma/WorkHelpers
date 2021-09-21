using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    class CabeceraFormularioCTMViewModel : BaseViewModel {
        private CabeceraFormularioCTM _cabeceraFormCtm;
        
        public CabeceraFormularioCTMViewModel() {
            _cabeceraFormCtm = new CabeceraFormularioCTM();            
        }

        public CabeceraFormularioCTMViewModel(CabeceraFormularioCTM cfctm) {
            _cabeceraFormCtm = cfctm;            
        }

        public CabeceraFormularioCTM DataObject {
            get { return _cabeceraFormCtm; }
            set {
                _cabeceraFormCtm = value;
                RaisePropertyChanged("DataObject");
            }
        }

        #region Properties
        public string Fecha {
            get { return _cabeceraFormCtm.Fecha; }
            set {
                if (_cabeceraFormCtm.Fecha != value) {
                    _cabeceraFormCtm.Fecha = value;
                    RaisePropertyChanged("Fecha");
                }
            }
        }

        public string NombreProcedimiento {
            get { return _cabeceraFormCtm.NombreProc; }
            set {
                if (_cabeceraFormCtm.NombreProc != value) {
                    _cabeceraFormCtm.NombreProc = value;
                    RaisePropertyChanged("NombreProcedimiento");
                }
            }
        }

        public string Usuario {
            get { return _cabeceraFormCtm.Usuario; }
            set {
                if (_cabeceraFormCtm.Usuario != value) {
                    _cabeceraFormCtm.Usuario = value;
                    RaisePropertyChanged("Usuario");
                }
            }
        }

        public string Area {
            get { return _cabeceraFormCtm.Area; }
            set {
                if (_cabeceraFormCtm.Area != value) {
                    _cabeceraFormCtm.Area = value;
                    RaisePropertyChanged("Area");
                }
            }
        }

        public string Descr {
            get { return _cabeceraFormCtm.Descr; }
            set {
                if (_cabeceraFormCtm.Descr != value) {
                    _cabeceraFormCtm.Descr = value;
                    RaisePropertyChanged("Descr");
                }
            }
        }

        public TipoPeriodicidad Periodicidad {
            get { return _cabeceraFormCtm.Periodicidad; }
            set {
                if (_cabeceraFormCtm.Periodicidad != value) {
                    _cabeceraFormCtm.Periodicidad = value;
                    RaisePropertyChanged("Periodicidad");
                }
            }
        }

        public string DetalleFrecuencia {
            get { return _cabeceraFormCtm.DetalleFrecuencia; }
            set {
                if (_cabeceraFormCtm.DetalleFrecuencia != value) {
                    _cabeceraFormCtm.DetalleFrecuencia = value;
                    RaisePropertyChanged("DetalleFrecuencia");
                }
            }
        }

        public int HoraInicioEjecucion {
            get { return _cabeceraFormCtm.HoraInicioEjecucion; }
            set {
                if (_cabeceraFormCtm.HoraInicioEjecucion != value) {
                    _cabeceraFormCtm.HoraInicioEjecucion = value;
                    RaisePropertyChanged("HoraInicioEjecucion");
                }
            } 
        }

        public int MinutosInicioEjecucion {
            get { return _cabeceraFormCtm.MinutosInicioEjecucion; }
            set {
                if (_cabeceraFormCtm.MinutosInicioEjecucion != value) {
                    _cabeceraFormCtm.MinutosInicioEjecucion = value;
                    RaisePropertyChanged("MinutosInicioEjecucion");
                }
            }
        }

        public int HoraLimiteInicioEjecucion {
            get { return _cabeceraFormCtm.HoraLimiteInicioEjecucion; }
            set {
                if (_cabeceraFormCtm.HoraLimiteInicioEjecucion != value) {
                    _cabeceraFormCtm.HoraLimiteInicioEjecucion = value;
                    RaisePropertyChanged("HoraLimiteInicioEjecucion");
                }
            }
        }

        public int MinutosLimiteInicioEjecucion {
            get { return _cabeceraFormCtm.MinutosLimiteInicioEjecucion; }
            set {
                if (_cabeceraFormCtm.MinutosLimiteInicioEjecucion != value) {
                    _cabeceraFormCtm.MinutosLimiteInicioEjecucion = value;
                    RaisePropertyChanged("MinutosLimiteInicioEjecucion");
                }
            }
        }

        #endregion Properties

        override public string GetValidationError(string propertyName) {
            if (propertyName == "NombreProcedimiento") propertyName = "NombreProc";
            
            return _cabeceraFormCtm.GetValidationError(propertyName);
        }
    }
}
