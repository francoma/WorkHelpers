using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    public abstract class PasoViewModel<T> : BaseViewModel where T:Paso {
        private readonly T _dataObject;
        
        public PasoViewModel(T dataObject) {
            _dataObject = dataObject;
        }

        public T DataObject { get { return _dataObject; } }

        public TipoPaso TipoDePaso { 
            get { return _dataObject.TipoDePaso; }
            set {
                if (_dataObject.TipoDePaso != value) {
                    _dataObject.TipoDePaso = value;
                    RaisePropertyChanged("TipoDePaso");
                }
            }
        }
              
        public string ServidorTest {
            get { return _dataObject.ServidorTest; }
            set{
                if (_dataObject.ServidorTest != value){
                    _dataObject.ServidorTest = value;
                    RaisePropertyChanged("ServidorTest");
                }
            }
        }

        public string ServidorProd {
            get { return _dataObject.ServidorProd; }
            set{
                if (_dataObject.ServidorProd != value){
                    _dataObject.ServidorProd = value;
                    RaisePropertyChanged("ServidorProd");
                }
            }
        }

        public int NroPaso {
            get { return _dataObject.NroPaso; }
            set{
                if (_dataObject.NroPaso != value){
                    _dataObject.NroPaso = value;
                    RaisePropertyChanged("NroPaso");
                }
            }
        }

        public string TextoPaso {
            get { return _dataObject.TextoPaso; }
            set
            {
                if (_dataObject.TextoPaso != value) {
                    _dataObject.TextoPaso = value;
                    RaisePropertyChanged("TextoPaso");
                }
            }
        }
    }
}
