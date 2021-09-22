using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    class PasoCopiaArchivosViewModel : PasoViewModel<Paso> {
        private TransferenciaArchivoViewModel _origen;
        private TransferenciaArchivoViewModel _destino;

        public PasoCopiaArchivosViewModel() : base(new PasoCopiaArchivos()) {
            _origen = new TransferenciaArchivoViewModel(((PasoCopiaArchivos)base.DataObject).Origen);
            _destino = new TransferenciaArchivoViewModel(((PasoCopiaArchivos)base.DataObject).Destino);
        }

        public PasoCopiaArchivosViewModel(PasoCopiaArchivos p) : base(p) {
            _origen = new TransferenciaArchivoViewModel(p.Origen);
            _destino = new TransferenciaArchivoViewModel(p.Destino);
        }

        public TransferenciaArchivoViewModel Origen {
            get { return _origen; }
            set {
                _origen = value;
                ((PasoCopiaArchivos)DataObject).Origen = _origen.DataObject;
                RaisePropertyChanged("Origen");                
            }
        }

        public TransferenciaArchivoViewModel Destino {
            get { return _destino; }
            set
            {
                _destino = value;
                ((PasoCopiaArchivos)DataObject).Destino = _destino.DataObject;
                RaisePropertyChanged("Destino");
            }
        }

        public string Observaciones {
            get { return ((PasoCopiaArchivos)DataObject).Observaciones; }
            set {
                if (((PasoCopiaArchivos)DataObject).Observaciones != value) {
                    ((PasoCopiaArchivos)DataObject).Observaciones = value;
                    RaisePropertyChanged("Observaciones");
                }
            }
        }
        
        override public string GetValidationError(string propertyName) {
            return ((PasoCopiaArchivos)DataObject).GetValidationError(propertyName);
        }

        public override bool IsValid {
            get {
                return ((PasoCopiaArchivos)DataObject).IsValid;
            }
        }
    }
}
