using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    class PasoSQLViewModel : PasoViewModel<Paso> {

        public PasoSQLViewModel() : base(new PasoSQL()) { }

        public PasoSQLViewModel(PasoSQL p) : base(p) { }


        public string BaseDatosTest{
            get {return ((PasoSQL)DataObject).BaseDatosTest;}
            set {
                PasoSQL psql = (PasoSQL)DataObject;

                if (psql.BaseDatosTest != value){
                    psql.BaseDatosTest = value;
                    RaisePropertyChanged("BaseDatosTest");
                }
            }
        }

        public string BaseDatosProduccion {
            get { return ((PasoSQL)DataObject).BaseDatosProduccion; }
            set {
                PasoSQL psql = (PasoSQL)DataObject;

                if (psql.BaseDatosProduccion != value) {
                    psql.BaseDatosProduccion = value;
                    RaisePropertyChanged("BaseDatosProduccion");
                }
            }
        }

        public string UsuarioEjecucion {
            get { return ((PasoSQL)DataObject).UsuarioEjecucion; }
            set {
                PasoSQL psql = (PasoSQL)DataObject;

                if (psql.UsuarioEjecucion != value) {
                    psql.UsuarioEjecucion = value;
                    RaisePropertyChanged("UsuarioEjecucion");
                }                
            }
        }

        public string TextoSQL {
            get { return ((PasoSQL)DataObject).TextoSQL; }
            set {
                PasoSQL psql = (PasoSQL)DataObject;

                if (psql.TextoSQL != value) {
                    psql.TextoSQL = value;
                    RaisePropertyChanged("TextoSQL");
                }
            }
        }

        override public string GetValidationError(string propertyName) {
            return ((PasoSQL)DataObject).GetValidationError(propertyName);
        }

        public override bool IsValid {
            get {
                return ((PasoSQL)DataObject).IsValid;
            }
        }
    }
}

