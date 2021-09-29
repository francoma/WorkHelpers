using System;
using BNACTMFormGenerator.Model;

namespace BNACTMFormGenerator.ViewModel
{
    class TransferenciaArchivoViewModel : BaseViewModel {
        private TransferenciaArchivo _transferenciaArchivo;
        
        public TransferenciaArchivoViewModel(TransferenciaArchivo ta) {
            _transferenciaArchivo = ta;            
        }

        #region Properties
        public TransferenciaArchivo DataObject {
            get { return _transferenciaArchivo;  }
            set {
                _transferenciaArchivo = value;
                RaisePropertyChanged("OrigenArchivos");
                RaisePropertyChanged("ServidorTest");
                RaisePropertyChanged("ServidorProd");
                RaisePropertyChanged("ServidorTest");
                RaisePropertyChanged("ServidorProd");
                RaisePropertyChanged("RutaTest");
                RaisePropertyChanged("RutaProd");
                RaisePropertyChanged("ArchivoTest");
                RaisePropertyChanged("ArchivoProd");
                RaisePropertyChanged("FileOptionTest");
                RaisePropertyChanged("FileOptionProd");
                RaisePropertyChanged("RecordFormatTest"); 
                RaisePropertyChanged("RecordFormatProd");
                RaisePropertyChanged("LReclTest");
                RaisePropertyChanged("LReclProd");
                RaisePropertyChanged("BlkSizeTest");
                RaisePropertyChanged("BlkSizeProd");
            }
        }

        public TipoOrigen OrigenArchivos {
            get { return _transferenciaArchivo.OrigenArchivos; }
            set  {
                if (_transferenciaArchivo.OrigenArchivos != value) {
                    _transferenciaArchivo.OrigenArchivos = value;

                    switch (_transferenciaArchivo.OrigenArchivos) { 
                        case TipoOrigen.HOST:
                            ServidorTest = "HOST";
                            RutaTest = String.Empty;
                            ArchivoTest = "";
                            FileOptionTest = "REPLACE";                            
                            RecordFormatTest = "FB";
                            LReclTest = 0;
                            BlkSizeTest = 0;
                            
                            break;

                        case TipoOrigen.XCOM:
                            ServidorTest = "FSXCOM0001";                            
                            RutaTest = "\\\\FSXCOM0001\\XCOM";
                            ArchivoTest = String.Empty;
                            FileOptionTest = String.Empty;
                            RecordFormatTest = String.Empty;
                            LReclTest = 0;
                            BlkSizeTest = 0;
                            
                            break;

                        case TipoOrigen.STAGING:
                            ServidorTest = "[TUX80CT0001 | TUX80AT0001 (utilizar este último en caso de fallo del CT)]";
                            RutaTest = "/opt/staging/";
                            ArchivoTest = String.Empty;
                            FileOptionTest = String.Empty;
                            RecordFormatTest = String.Empty;
                            LReclTest = 0;
                            BlkSizeTest = 0;

                            ServidorProd = "[SUX80CT0001 | SUX80AT0001 (utilizar este último en caso de fallo del CT)]";

                            break;

                        case TipoOrigen.Otro:
                            ServidorTest = String.Empty;
                            RutaTest = String.Empty;
                            ArchivoTest = String.Empty;
                            FileOptionTest = String.Empty;
                            RecordFormatTest = String.Empty;
                            LReclTest = 0;
                            BlkSizeTest = 0;

                            break;
                    }

                    RaisePropertyChanged("OrigenArchivos");
                    RaisePropertyChanged("ServidorTest");
                    RaisePropertyChanged("ServidorProd");
                    RaisePropertyChanged("RutaTest");
                    RaisePropertyChanged("ArchivoTest");
                    RaisePropertyChanged("FileOptionTest");
                    RaisePropertyChanged("RecordFormatTest");
                    RaisePropertyChanged("LReclTest");
                    RaisePropertyChanged("BlkSizeTest");
                }
            }
        }

        public string ServidorTest {
            get {return _transferenciaArchivo.ServidorTest; }
            set  {
                if (_transferenciaArchivo.ServidorTest != value){
                    _transferenciaArchivo.ServidorTest = value;
                    ServidorProd = value;
                    RaisePropertyChanged("ServidorTest");
                    RaisePropertyChanged("ServidorProd");
                }
            }
        }
        
        public string ServidorProd {
            get {return _transferenciaArchivo.ServidorProd; }
            set  {
                if (_transferenciaArchivo.ServidorProd != value){
                    _transferenciaArchivo.ServidorProd = value;
                    RaisePropertyChanged("ServidorProd");
                }
            }
        }

        public string RutaTest {
            get {return _transferenciaArchivo.RutaTest; }
            set  {
                if (_transferenciaArchivo.RutaTest != value){
                    _transferenciaArchivo.RutaTest = value;
                    RutaProd = value;
                    RaisePropertyChanged("RutaTest");
                    RaisePropertyChanged("RutaProd");
                }
            }
        }

        public string RutaProd {
            get {return _transferenciaArchivo.RutaProd; }
            set  {
                if (_transferenciaArchivo.RutaProd != value){
                    _transferenciaArchivo.RutaProd = value;
                    RaisePropertyChanged("RutaProd");
                }
            }
        }

        public string ArchivoTest {
            get {return _transferenciaArchivo.ArchivoTest; }
            set  {
                if (_transferenciaArchivo.ArchivoTest != value){
                    _transferenciaArchivo.ArchivoTest = value;
                    ArchivoProd = value;
                    RaisePropertyChanged("ArchivoTest");
                    RaisePropertyChanged("ArchivoProd");
                }
            }
        }
        
        public string ArchivoProd {
            get {return _transferenciaArchivo.ArchivoProd; }
            set  {
                if (_transferenciaArchivo.ArchivoProd != value){
                    _transferenciaArchivo.ArchivoProd = value;
                    RaisePropertyChanged("ArchivoProd");
                }
            }
        }

        public string FileOptionTest {
            get {return _transferenciaArchivo.FileOptionTest; }
            set  {
                if (_transferenciaArchivo.FileOptionTest != value){
                    _transferenciaArchivo.FileOptionTest = value;
                    FileOptionProd = value;
                    RaisePropertyChanged("FileOptionTest");
                    RaisePropertyChanged("FileOptionProd");
                }
            }
        }
        
        public string FileOptionProd {
            get {return _transferenciaArchivo.FileOptionProd; }
            set  {
                if (_transferenciaArchivo.FileOptionProd != value){
                    _transferenciaArchivo.FileOptionProd = value;
                    RaisePropertyChanged("FileOptionProd");
                }
            }
        }

        public string RecordFormatTest {
            get {return _transferenciaArchivo.RecordFormatTest; }
            set  {
                if (_transferenciaArchivo.RecordFormatTest != value){
                    _transferenciaArchivo.RecordFormatTest = value;
                    RecordFormatProd = value;
                    RaisePropertyChanged("RecordFormatTest");
                    RaisePropertyChanged("RecordFormatProd");
                }
            }
        }

        public string RecordFormatProd {
            get {return _transferenciaArchivo.RecordFormatProd; }
            set  {
                if (_transferenciaArchivo.RecordFormatProd != value){
                    _transferenciaArchivo.RecordFormatProd = value;                    
                    RaisePropertyChanged("RecordFormatProd");
                }
            }
        }

        public int LReclTest {
            get {return _transferenciaArchivo.LReclTest; }
            set  {
                if (_transferenciaArchivo.LReclTest != value){
                    _transferenciaArchivo.LReclTest = value;
                    LReclProd = value;
                    RaisePropertyChanged("LReclTest");
                    RaisePropertyChanged("LReclProd");
                }
            }
        }

        public int LReclProd {
            get {return _transferenciaArchivo.LReclProd; }
            set  {
                if (_transferenciaArchivo.LReclProd != value){
                    _transferenciaArchivo.LReclProd = value;
                    RaisePropertyChanged("LReclProd");
                }
            }
        }

        public int BlkSizeTest {
            get {return _transferenciaArchivo.BlkSizeTest; }
            set  {
                if (_transferenciaArchivo.BlkSizeTest != value){
                    _transferenciaArchivo.BlkSizeTest = value;
                    BlkSizeProd = value;
                    RaisePropertyChanged("BlkSizeTest");
                    RaisePropertyChanged("BlkSizeProd");
                }
            }
        }

        public int BlkSizeProd {
            get {return _transferenciaArchivo.BlkSizeProd; }
            set  {
                if (_transferenciaArchivo.BlkSizeProd != value){
                    _transferenciaArchivo.BlkSizeProd = value;
                    RaisePropertyChanged("BlkSizeProd");
                }
            }
        }

        #endregion

        override public string GetValidationError(string propertyName) {
            return _transferenciaArchivo.GetValidationError(propertyName);
        }

        override public bool IsValid {
            get {
                return _transferenciaArchivo.IsValid;
            }
        }

    }
}