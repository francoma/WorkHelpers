using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    class PasoEliminacionArchivosViewModel : PasoViewModel<Paso> {

        public PasoEliminacionArchivosViewModel() :base(new PasoEliminacionArchivos()){ }
        
        public PasoEliminacionArchivosViewModel(PasoEliminacionArchivos p) : base(p) { }

        public string RutaTest {
            get { return ((PasoEliminacionArchivos)DataObject).RutaTest; }
            set {
                PasoEliminacionArchivos psp = (PasoEliminacionArchivos)DataObject;
                if (psp.RutaTest != value) {
                    psp.RutaTest = value;
                    RaisePropertyChanged("RutaTest");
                }
            }
        }

        public string RutaProd {
            get { return ((PasoEliminacionArchivos)DataObject).RutaProd; }
            set {
                PasoEliminacionArchivos psp = (PasoEliminacionArchivos)DataObject;
                if (psp.RutaProd != value) {
                    psp.RutaProd = value;
                    RaisePropertyChanged("RutaProd");
                }
            }
        }

        public string ArchivosOPatron {
            get { return ((PasoEliminacionArchivos)DataObject).ArchivosOPatron; }
            set {
                PasoEliminacionArchivos psp = (PasoEliminacionArchivos)DataObject;
                if (psp.ArchivosOPatron != value) {
                    psp.ArchivosOPatron = value;
                    RaisePropertyChanged("ArchivosOPatron");
                }
            }
        }

        override public string GetValidationError(string propertyName) {
            return ((PasoEliminacionArchivos)DataObject).GetValidationError(propertyName);
        }

        public override bool IsValid {
            get {
                return ((PasoEliminacionArchivos)DataObject).IsValid;
            }
        }

    }
}
